using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMover playerMover;
    private PlayerBulletGenerator playerBulletGenerator;

    void Awake()
    {
        playerMover = new PlayerMover(this.gameObject);
        playerBulletGenerator = GetComponent<PlayerBulletGenerator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(playerBulletGenerator.GenerateBullet());
        }
        playerMover.ShotDirection();
    }

}
