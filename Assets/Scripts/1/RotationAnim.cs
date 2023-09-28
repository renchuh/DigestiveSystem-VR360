using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnim : MonoBehaviour
{
    public Vector3 axis;

    public float speed;

    public bool rotateEnabled = true;
    private void Update()
    {

        if (rotateEnabled)
        {
            transform.Rotate(axis, speed * Time.deltaTime);
        }
       
    }

    public void StartRotate()
    {
        rotateEnabled = true;
    }
}
