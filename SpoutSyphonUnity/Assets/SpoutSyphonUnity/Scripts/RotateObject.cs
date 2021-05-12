using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    Vector3 _axis = Vector3.zero;

    void Start()
    {
        _axis = Random.insideUnitSphere;
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, _axis, 10.0f * Time.deltaTime);
    }
}
