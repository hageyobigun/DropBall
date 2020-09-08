using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot
{
    private float speed;
    private readonly Vector3 shotPos;

    public BulletShot(Vector3 vector3)
    {
        shotPos = vector3;
    }

    public void ShotBalls(Rigidbody2D rb, GameObject shotTarget)
    {
        speed = 100;
        Vector3 shotDirection = shotTarget.transform.position - shotPos;
        rb.AddForce(shotDirection * speed);
    }
}
