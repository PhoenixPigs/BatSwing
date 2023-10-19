using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public bool inTarget;
    public float speed = 4f;
   // public Pause _pause;
    private void Awake()
    {
      //  _pause = FindObjectOfType<Pause>();
    }
    void Update()
    {
        //if (_pause.GetIsPaused()) { return; }
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
    private void Start()
    {
        inTarget = false;
    }
}
