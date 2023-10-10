using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRigidBody;

    private void Start()
    {
        ballRigidBody = this.GetComponent<Rigidbody>();
    }

    public void BallMove(Vector3 direction)
    {
        ballRigidBody.AddForce(direction);
    }
}
