using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [Header("Strike")]
    public float strikeMax = 1f;
    public float fillSpeed = 0.5f;
    private float targetProgress = 0;
    public Image strikeBar;
    public AudioSource deathSound;
    public AudioSource hitSound;

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
    //public Pause _pause;
    private void Awake()
    {
      //  _pause = FindObjectOfType<Pause>();
    }
    private void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (strikeBar.fillAmount < 1 && other.transform.gameObject.tag == "Red" || strikeBar.fillAmount < 1 && other.transform.gameObject.tag == "Green" || strikeBar.fillAmount < 1 && other.transform.gameObject.tag == "Blue" || strikeBar.fillAmount < 1 && other.transform.gameObject.tag == "Purple")
        {
            Destroy(other.gameObject);

            comboAm = 0;
            shaderOff();
            comboBar.maxValue = 10;
            comboBar.value = 0;
            sliderChange();
            ScreenShakeManager.instance.CameraShake(impulseSource);
            deathSound.Play();
            strikeBar.fillAmount = 0;
            SceneManager.LoadScene(0);
        }
        if (strikeBar.fillAmount >= 1 && other.transform.gameObject.tag == "Red"|| strikeBar.fillAmount >= 1 && other.transform.gameObject.tag == "Green" || strikeBar.fillAmount >= 1 && other.transform.gameObject.tag == "Blue" || strikeBar.fillAmount >= 1 && other.transform.gameObject.tag == "Purple")
        {
            Debug.Log("STRIKE!");

            Destroy(other.gameObject);

            comboAm = 0;
            shaderOff();
            comboBar.maxValue = 10;
            comboBar.value = 0;
            sliderChange();
            ScreenShakeManager.instance.CameraShake(impulseSource);
            hitSound.Play();
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
           // if (_pause.GetIsPaused()) { return; }
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