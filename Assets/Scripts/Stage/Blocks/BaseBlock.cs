using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBlock : MonoBehaviour, IDamagable
{
    [SerializeField] private int hpValue = 10;

    protected bool IsDead() => --hpValue <= 0;

    protected int RandomHpValue() => hpValue = Random.Range(5, 40);

    public abstract void AddDamage();

    public abstract void MoveBlock();
}
