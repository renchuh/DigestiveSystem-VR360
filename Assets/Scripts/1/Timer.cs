using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public float time =10;


    public UnityEvent OnTime;


    private float timer;
    private bool called;
    void Update()
    {
         timer += Time.deltaTime;

       if(timer >= time && !called)
        {
            OnTime?.Invoke();
            called = true;
        }
    }
     
}
