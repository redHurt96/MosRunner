using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float speed = 20;
    public float X = 0;
    public float Y = 0;
    public float Z = 0;
            
    void Update()
    {
        transform.Rotate(new Vector3(X, Y, Z) * Time.deltaTime * speed);
    }
}
