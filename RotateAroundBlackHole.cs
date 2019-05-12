using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundBlackHole : MonoBehaviour
{
    [SerializeField]
    private Transform Target;

    [SerializeField]
    private float Speed=10f;

    protected void Update()
    {
        transform.RotateAround(Target.position,Vector3.up,Time.deltaTime*Speed);
    }
}
