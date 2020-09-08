using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject bullet = null;
    [SerializeField] private GameObject shotTarget = null;
    [SerializeField] private int shotCount = 10;
    private BulletShot bulletShot;

    private void Awake()
    {
        bulletShot = new BulletShot(this.transform.position);
    }

    public IEnumerator GenerateBullet()
    {
        for (int i = 0; i < shotCount; i++)
        {
            GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
            bulletShot.ShotBalls(bulletClone.GetComponent<Rigidbody2D>(), shotTarget);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
