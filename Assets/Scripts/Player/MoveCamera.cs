using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Camera _cam;

    private void Start()
    {
        _cam = Camera.main;
    }

    private void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.z = _cam.transform.position.z;
        _cam.transform.position = pos;
    }
}
