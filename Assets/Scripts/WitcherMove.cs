using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitcherMove : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 60f;
    float jumpPower = 500f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float right = Input.GetAxis("Horizontal");
        if(right!=0)
        {
            var position = transform.position;
            position += Vector3.right * right * Time.deltaTime * speed;
            rb.MovePosition(position);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var position =transform.position;
            position += Vector3.up * Time.deltaTime * jumpPower;
            rb.MovePosition(position);
        }
    }
}
