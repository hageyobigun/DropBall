using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerShot playerShot;
    private PlayerMover playerMover;

    private GameObject shotBall;

    public GameObject bullet;
    public GameObject shotLine;
    public GameObject shotDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerShot = new PlayerShot(shotLine);
        playerMover = new PlayerMover(shotLine);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            shotBall = Instantiate(bullet, shotLine.transform.position, Quaternion.identity);
            playerShot.ShotBalls(shotBall.GetComponent<Rigidbody2D>(), shotDirection);
        }
        playerMover.ShotDirection();
    }
}
