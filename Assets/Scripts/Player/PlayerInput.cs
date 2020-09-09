using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IPlayerInput
{
    public bool IsAttack() => Input.GetKeyDown(KeyCode.Space);
}
