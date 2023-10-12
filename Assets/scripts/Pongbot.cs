using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UIElements;

public class Pongbot : MonoBehaviour
{
    public float ySpeed = 3f;
    public float yPosition = 0;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        if (yPosition <= -3.16f)
        {
            ySpeed = ySpeed * 1f;
        }
        else if (yPosition <= -3.16f)
        {
            ySpeed = ySpeed * 1f;
        }
    }
}

