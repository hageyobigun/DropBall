using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBlock : BaseBlock
{

    public override void AddDamage()
    {
        if (IsDead())
        {
            Destroy(this.gameObject);
        }
    }
}
