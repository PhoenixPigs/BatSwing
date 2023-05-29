using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

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

    private void Start()
    {
        strike1.SetActive(false);
        strike2.SetActive(false);
        strike3.SetActive(false);
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
        }
    }
    private void Update()
    {
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
        }
        if (comboAm >= 10 && comboAm < 50)
        {
            comboMul = 2;
        }
        if (comboAm >= 50)
        {
            comboMul = 3;
        }

        score.text = "" + scoreAm;
        combo.text = "COMBO: " + comboAm;
    }
}
