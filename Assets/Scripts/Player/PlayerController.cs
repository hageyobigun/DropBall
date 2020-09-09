using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMover playerMover;
    private PlayerInput playerInput;
    private PlayerBulletGenerator playerBulletGenerator;

    void Awake()
    {
        playerMover = new PlayerMover(this.gameObject);
        playerInput = new PlayerInput();
        playerBulletGenerator = GetComponent<PlayerBulletGenerator>();
    }

    void Update()
    {
        if (playerInput.IsAttack())
        {
            StartCoroutine(playerBulletGenerator.GenerateBullet());
        }
        playerMover.ShotDirection();
    }

}
