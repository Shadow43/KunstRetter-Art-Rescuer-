using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerRigidBody != null)
        {
            float xInput = Input.GetAxis("Horizontal");
            float xForce = xInput * moveSpeed * Time.deltaTime;
//            Vector2 force = new Vector2(xForce, 0);
//            PlayerRigidBody.AddForce(force);
            transform.Translate(new Vector2(xForce, 0));
        }

        else
        {
            Debug.LogWarning("Rigid body not attached to player" + gameObject.name);
        }
    }

}
