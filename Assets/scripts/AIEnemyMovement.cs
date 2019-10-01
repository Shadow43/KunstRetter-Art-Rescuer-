using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemyMovement : MonoBehaviour
{
    public float EnemySpeed;
    private Rigidbody2D EnemyRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        EnemyRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (new Vector3 (EnemySpeed, 0,0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            EnemySpeed *= -1;
        }
    }
}
