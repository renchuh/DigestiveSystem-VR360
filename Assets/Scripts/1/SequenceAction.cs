using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SequenceAction : MonoBehaviour
{
    public MyAction[] events;


    private float currTime;


    private void Update()
    { 

        foreach(var v in events)
        {
            if(currTime< v.timestamp && Time.timeSinceLevelLoad >= v.timestamp)
            {
                v.action?.Invoke();
            }
        }
        currTime = Time.timeSinceLevelLoad;
    }


}

[System.Serializable]   
public class MyAction
{
    public float timestamp;

    public UnityEvent action;
}
