using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{
    public BallController ballController;
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            ballController.BallMove(Vector3.forward);
        }
        if (Keyboard.current.aKey.isPressed)
        {
            ballController.BallMove(Vector3.left);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            ballController.BallMove(Vector3.back);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            ballController.BallMove(Vector3.right);
        }
    }
}
