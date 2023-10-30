using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ball : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;

    // Start is called before the first frame update
    void Start()
    {
       Yposition = Random.Range(-5.0f, 5.0f);
        transform.position = new Vector3(Xposition, Yposition, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Xposition = Xposition + 5f * Time.deltaTime;
        Yposition = Yposition + 5f * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);

    }
}



