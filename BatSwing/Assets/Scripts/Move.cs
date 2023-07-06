using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class Move : MonoBehaviour
{

    public Transform leftPos;
    public Transform rightPos;
    public Transform midPos;

    [SerializeField] float lerpTime = 1f; // how long do you want the move to take

    public bool leftT;
    public bool rightT;
    public bool midT;

    public Animator playerAnim;

    public VisualEffect IsmokeLeft;
    public VisualEffect IsmokeRight;
    public VisualEffect OsmokeLeft;
    public VisualEffect OsmokeRight;


    public bool lerping;

    private void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && midT)
        {
            //playerAnim.SetBool("MidToRight", true);
            //gameObject.transform.position = leftPos.transform.position;

            lerping = true;
            Vector3 startPos = gameObject.transform.position;
            Vector3 endPos = leftPos.transform.position;
            IsmokeLeft.Play();

            StartCoroutine(Lerping(startPos, endPos));
            midT = false;
            leftT = true;
            Debug.Log("Left");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && rightT)
        {
            lerping = true;
            Vector3 startPos = gameObject.transform.position;
            Vector3 endPos = midPos.transform.position;
            OsmokeLeft.Play();

            StartCoroutine(Lerping(startPos, endPos));
            rightT = false;
            midT = true;
            Debug.Log("Mid");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && midT)
        {
            lerping = true;
            Vector3 startPos = gameObject.transform.position;
            Vector3 endPos = rightPos.transform.position;
            IsmokeRight.Play();

            StartCoroutine(Lerping(startPos, endPos));
            midT = false;
            rightT = true;
            Debug.Log("Right");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && leftT)
        {
            lerping = true;
            Vector3 startPos = gameObject.transform.position;
            Vector3 endPos = midPos.transform.position;
            OsmokeRight.Play();

            StartCoroutine(Lerping(startPos, endPos));
            leftT = false;
            midT = true;
            Debug.Log("Mid");
        }

    }

    IEnumerator Lerping(Vector3 startLerpPos, Vector3 endLerpPos)
    {
        float time = 0;


        while (time < lerpTime && lerping)
        {

            transform.position = Vector3.Lerp(startLerpPos, endLerpPos, time/lerpTime);
            
            yield return new WaitForEndOfFrame();

            time += Time.deltaTime;
        }
        gameObject.transform.position = endLerpPos;
        lerping = false;
        //set transform to end position
        // pos = endPos
    }

    //public void MidToRightFalse()
    //{
     //   playerAnim.SetBool("MidToRight", false);
        
    //}
}
