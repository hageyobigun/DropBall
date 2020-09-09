using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCount
{
    public static bool IsBullet()
    {
        var bulletCount = GameObject.FindGameObjectWithTag("bullet");
        if (bulletCount == null) return (false);
        return (true);
    }
}
