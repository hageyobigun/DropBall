using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var damagable = collision.gameObject.GetComponent<IDamagable>();
        if (damagable != null)
        {
            damagable.AddDamage();
        }
    }

    //画面外削除
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
