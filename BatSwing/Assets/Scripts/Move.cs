using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{

    public Transform leftPos;
    public Transform rightPos;
    public Transform midPos;


    public bool leftT;
    public bool rightT;
    public bool midT;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && midT)
        {
            gameObject.transform.position = leftPos.transform.position;
            midT = false;
            leftT = true;
            Debug.Log("Left");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && rightT)
        {
            gameObject.transform.position = midPos.transform.position;
            midT = true;
            rightT = false;
            Debug.Log("Mid");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && leftT)
        {
            gameObject.transform.position = midPos.transform.position;
            midT = true;
            leftT = false;
            Debug.Log("Mid");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && midT)
        {
            gameObject.transform.position = rightPos.transform.position;
            midT = false;
            rightT = true;
            Debug.Log("Right");
        }
    }
}
