using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBlock : BaseBlock
{
    private bool isMove;

    public void Awake()
    {
        isMove = false;
        RandomHpValue();
    }

    public void Update()
    {
        MoveBlock();
    }

    public override void MoveBlock()
    {
        if (BulletCount.IsBullet())isMove = true;//弾が発射された
        if (isMove && !BulletCount.IsBullet()) //発射された弾が全部消えた
        {
            transform.position += new Vector3(0, 0.5f, 0);
            isMove = false;
        }
    }

    public override void AddDamage()
    {
        if (IsDead())
        {
            Destroy(this.gameObject);
        }
    }

}
