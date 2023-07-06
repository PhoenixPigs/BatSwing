using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public bool inTarget;
    public float speed = 4f;
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
    private void Start()
    {
        inTarget = false;
    }
}
