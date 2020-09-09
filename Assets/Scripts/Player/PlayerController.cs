using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMover playerMover;
    private PlayerInput playerInput;
    private PlayerShot playerShot;

    void Awake()
    {
        playerMover = new PlayerMover(this.gameObject);
        playerInput = new PlayerInput();
        playerShot = GetComponent<PlayerShot>();
    }

    void Update()
    {

        if (playerInput.IsAttack())
        {
            StartCoroutine(playerShot.GenerateBullet());
        }
        if (!BulletCount.IsBullet())
        {
            playerMover.ShotDirection();
        }
    }

}
