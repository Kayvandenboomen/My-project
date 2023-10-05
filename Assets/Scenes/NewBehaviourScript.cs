using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    //update is called once per frame
    void Update() {

        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
    
    

}