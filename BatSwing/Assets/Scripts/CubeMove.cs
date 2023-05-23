using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{

    public float speed = 4f;
    // Start is called before the first frame update
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
}
