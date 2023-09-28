using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{

    public void ScaleBall(float mul)
    {
        foreach(Transform t in transform)
        {
            t.localScale*=mul;
        }
    }
     
}
