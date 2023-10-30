using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBotHorizontal : MonoBehaviour
{
    public float xSpeed = 3f;
    private float xPosition = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, transform.position.y, transform.position.z); // Move horizontally while keeping the same y and z positions.

        // Check if the paddle is too far to the right or left and reverse its direction.
        if (xPosition >= 5.35f || xPosition <= -5.35f)
        {
            xSpeed = -xSpeed;
        }
    }
}



