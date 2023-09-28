using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    public UnityEvent OnClick;

    public UnityEvent OnGaze;


    private float gazeTimer;
    private bool gazing;
    public void OnPointerClick()
    {
        OnClick?.Invoke();
    }

    public void OnPointerEnter()
    {
        gazing = true;
    }


    public void OnPointerExit()
    {
        gazing = false;
        gazeTimer = 0;
    }


    private void Update()
    {
        if(gazing)
        {
            gazeTimer+= Time.deltaTime;
            if(gazeTimer > 1)
            {
                OnGaze?.Invoke();
                gazing = false;
                gazeTimer = 0;
            }
        }
    }
}
