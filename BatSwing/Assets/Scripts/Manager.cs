using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public int strikeCount = 0;

    public GameObject strike1;
    public GameObject strike2;
    public GameObject strike3;

    public TMP_Text score;
    public TMP_Text combo;

    public int scoreAm;
    public int comboAm;

    public int comboMul;

    public float lerpSpeed;
    public Slider comboBar;

    public float comboAmF;
    public float comboBarF;

    float currentVelocity = 0;

    public TMP_Text comboMultiplier;

    public Image strikeBar;

    public float strikeMax = 1f;
    bool strikeLerp;
    public float smoothTime;


    public float fillSpeed = 0.5f;
    private float targetProgress = 0;


    private void Start()
    {
        strike1.SetActive(false);
        strike2.SetActive(false);
        strike3.SetActive(false);
        strikeLerp = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");

        if (other.transform.gameObject.tag == "Red" || other.transform.gameObject.tag == "Green" || other.transform.gameObject.tag == "Blue" || other.transform.gameObject.tag == "Purple")
        {
            Debug.Log("STRIKE!");

            strikeCount++;
            Destroy(other.gameObject);
            comboAm = 0;
            
            comboBar.maxValue = 10;
            sliderChange();
            strikeBar.fillAmount = 0;
            //strikeLerp = true;
            incrementProgress(1f);
        }
    }

    public void sliderChange()
    {
        Debug.Log("Start");
        comboBar.value = comboAm;
        Debug.Log("change");
    }

    private void Update()
    {
        if (strikeBar.fillAmount < targetProgress)
        {
            strikeBar.fillAmount += fillSpeed * Time.deltaTime;
        }

        if (strikeLerp)
        {
            strikeBar.fillAmount = Mathf.SmoothDamp(strikeBar.fillAmount, strikeMax, ref currentVelocity, smoothTime);
            //strikeLerp = false;
        }
   
        comboBarF = comboBar.value;
        comboAmF = comboAm;
        lerpSpeed = smoothTime * Time.deltaTime;

        if (strikeCount == 1)
        {
            strike1.SetActive(true);
        }
        if (strikeCount == 2)
        {
            strike2.SetActive(true);
        }
        if (strikeCount == 3)
        {
            strike3.SetActive(true);
        }
        if (strikeCount >= 3)
        {

        }
        if (comboAm >= 0 && comboAm < 10)
        {
            comboMul = 1;
            comboBar.minValue = 0;
            comboBar.maxValue = 10;
        }
        if (comboAm >= 10 && comboAm < 50)
        {
            comboMul = 2;
            comboBar.minValue = 10;
            comboBar.maxValue = 40;
            if (comboAm == 10)
            {
                comboBar.value = 0;
            }
        }
        if (comboAm >= 50)
        {
            comboMul = 3;
        }


        score.text = "" + scoreAm;
        combo.text = "X" + comboMul;
    }
    void incrementProgress(float newProgress)
    {
        targetProgress = strikeBar.fillAmount + newProgress;
    }
}
