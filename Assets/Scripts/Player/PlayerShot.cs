using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    private float speed;
    private GameObject shotLine;

    public PlayerShot(GameObject gameObject)
    {
        shotLine = gameObject;
    }

    public void ShotBalls(Rigidbody2D rb, GameObject shotAngle)
    {
        speed = 100;
        Vector3 shotDirection = shotAngle.transform.position - shotLine.transform.position;
        rb.AddForce(shotDirection * speed);
    }
}
