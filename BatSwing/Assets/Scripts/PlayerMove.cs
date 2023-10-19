using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 3;
    public float lerpDuration = 40;
    public float startValue = 10;
    public float endValue = 50;

    //public Pause _pause;
    //private void Awake()
    //{
    //    _pause = FindObjectOfType<Pause>();
   // }
    void Start()
    {
        StartCoroutine(Lerp());
    }
    IEnumerator Lerp()
    {
        float timeElapsed = 0;
        while (timeElapsed < lerpDuration)
        {
            moveSpeed = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        moveSpeed = endValue;
    }

    // Update is called once per frame
    void Update()
    {        
       // if (_pause.GetIsPaused()) { return; }
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
    }
}
