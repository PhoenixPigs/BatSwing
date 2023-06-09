using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class Manager : MonoBehaviour
{
    [Header("Strike")]
    public float strikeMax = 1f;
    public float fillSpeed = 0.5f;
    private float targetProgress = 0;
    public Image strikeBar;
    public AudioSource death;

    [Header("Score")]
    public int scoreAm;
    public TMP_Text score;

    [Header("Combo")]
    public int comboAm;
    public int comboMul;
    public Slider comboBar;
    public TMP_Text combo;
    public Material rainbowShader;
    public Image comboMa;

    CinemachineImpulseSource impulseSource;

    private void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Red" || other.transform.gameObject.tag == "Green" || other.transform.gameObject.tag == "Blue" || other.transform.gameObject.tag == "Purple")
        {
            Debug.Log("STRIKE!");

            Destroy(other.gameObject);

            comboAm = 0;
            shaderOff();
            comboBar.maxValue = 10;
            comboBar.value = 0;
            sliderChange();
            ScreenShakeManager.instance.CameraShake(impulseSource);
            death.Play();
            strikeBar.fillAmount = 0;
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
            comboBar.maxValue = 50;
            if (comboAm == 10)
            {
                comboBar.value = 0;
            }
        }
        if (comboAm >= 50)
        {
            comboBar.minValue = 50;
            comboBar.maxValue = 100;
            comboMul = 3;
            shaderOn();
        }


        score.text = "" + scoreAm;
        combo.text = "X" + comboMul;
    }
    void incrementProgress(float newProgress)
    {
        targetProgress = strikeBar.fillAmount + newProgress;
    }

    void shaderOn()
    {
        comboMa.GetComponent<Image>().material = rainbowShader;
    }
    public void shaderOff()
    {
        comboMa.GetComponent<Image>().material = null;
    }
}