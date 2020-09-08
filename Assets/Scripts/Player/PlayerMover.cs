using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover
{
    private readonly GameObject player;

    public PlayerMover(GameObject gameObject)
    {
        player = gameObject;
    }

    public void ShotDirection()
    {
        var angle = GetShotAngle();
        player.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    //角度取得
    public float GetShotAngle()
    {
        Vector3 mouseVec = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position).normalized;
        mouseVec = new Vector3(mouseVec.x, mouseVec.y, 0);

        var angle = Vector3.Angle(new Vector3(0, -1, 0), mouseVec);
        angle = Mathf.Clamp(angle, -50, 50);
        if (mouseVec.x < 0) angle = -angle;
        return (angle);
    }

}
