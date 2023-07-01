using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [Header ("Strike")]
    public int strikeCount = 0;
    public float strikeMax = 1f;
    public float fillSpeed = 0.5f;
    private float targetProgress = 0;
    public Image strikeBar;

    [Header("Score")]
    public int scoreAm;
    public TMP_Text score;

    [Header("Combo")]
    public int comboAm;
    public int comboMul;
    public Slider comboBar;
    public TMP_Text combo;

    [Header("Camera")]
    public ScreenShake _screenShake;

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
            StartCoroutine(_screenShake.Shake(.15f, .4f));
            incrementProgress(1f);
        }
    }

    public void sliderChange()
    {
        comboBar.value = comboAm;
    }

    private void Update()
    {
        if (strikeBar.fillAmount < targetProgress)
        {
            strikeBar.fillAmount += fillSpeed * Time.deltaTime;
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
