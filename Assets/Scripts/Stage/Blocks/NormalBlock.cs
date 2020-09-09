using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBlock : BaseBlock
{
    private bool isMove;

    public void Awake()
    {
        isMove = false;
    }

    public void Update()
    {
        MoveBlock();
    }

    public override void MoveBlock()
    {
        if (BulletCount.IsBullet())isMove = true;
        if (isMove && !BulletCount.IsBullet())
        {
            transform.position += transform.up;
            isMove = false;
        }
    }

    public override void AddDamage()
    {
        if (IsDead())Destroy(this.gameObject);
    }

}
