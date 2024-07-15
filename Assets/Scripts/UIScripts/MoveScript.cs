using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Vector3 StartPos;
    Vector3 TargetPos;
    float lerpTime = 8f;
    Vector3 CentralPos;
    bool NeedToMove = false;
    private void Awake()
    {
        StartPos = transform.position;
        CentralPos = AppManager.Instance.CentralPosition.position;
    }
    private void FixedUpdate()
    {
        if (NeedToMove)
        {
            transform.position = Vector3.Lerp(transform.position, TargetPos, lerpTime * Time.deltaTime);
            if (transform.position == TargetPos) NeedToMove = false;
        }
    }
    private void OnEnable()
    {
        NeedToMove = true;
        transform.position = StartPos;
        TargetPos = CentralPos;
    }

}
