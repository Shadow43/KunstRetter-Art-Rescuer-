using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D PlayerRigidBody;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        if (PlayerRigidBody != null)
        {
            ApplyInput();
        }

        else
        {
            Debug.LogWarning("Rigid body not attached to player" + gameObject.name);
        }
    }

    //Check to see if arrow keys are pressed and move character

    public void ApplyInput()
    {
        float xInput = Input.GetAxis("x");
        float yInput = Input.GetAxis("y");

        float xForce = xInput * moveSpeed * Time.deltaTime;
        Vector2 force = new Vector2(xForce, 0);
        PlayerRigidBody.AddForce(force);

        Debug.Log("xForce: " + xForce);
        Debug.Log("VelocityplayerRigidbody " + PlayerRigidBody.velocity);
    }
}
