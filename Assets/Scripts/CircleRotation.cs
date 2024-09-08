using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation: MonoBehaviour
{
    public Transform center; 
    public float radius; 
    public float speed; 

    private bool isClockwise = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            isClockwise = !isClockwise;  
        }

        float direction = isClockwise ? 1f : -1f;

        transform.RotateAround(center.position, Vector3.forward, speed * direction * Time.deltaTime);

        Vector3 offset = (transform.position - center.position).normalized * radius;
        transform.position = center.position + offset;
    }
}
