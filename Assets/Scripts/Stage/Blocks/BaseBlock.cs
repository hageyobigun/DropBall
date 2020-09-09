using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBlock : MonoBehaviour, IDamagable
{
    [SerializeField] private int hpValue = 10;

    protected bool IsDead() => --hpValue <= 0;

    public abstract void AddDamage();
}
