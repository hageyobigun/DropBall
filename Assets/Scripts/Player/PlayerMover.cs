using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private GameObject shotLine;

    public PlayerMover(GameObject gameObject)
    {
        shotLine = gameObject;
    }

    public void ShotDirection()
    {
        var angle = GetShotAngle();
        shotLine.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    //角度取得
    public float GetShotAngle()
    {
        Vector3 mouseVec = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - shotLine.transform.position).normalized;
        mouseVec = new Vector3(mouseVec.x, mouseVec.y, 0);

        var angle = Vector3.Angle(new Vector3(0, -1, 0), mouseVec);
        angle = Mathf.Clamp(angle, -50, 50);
        if (mouseVec.x < 0) angle = -angle;
        return (angle);
    }

}
