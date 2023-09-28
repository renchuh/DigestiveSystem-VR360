using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnim : MonoBehaviour
{
    public Transform target;

    public Transform animObj;

    public float duration = 2;



    public void Move()
    {
        animObj.DOMove(target.position, duration);
        animObj.DORotateQuaternion(target.rotation, duration);
    }
}
