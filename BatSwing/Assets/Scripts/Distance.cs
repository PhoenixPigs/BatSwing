using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Image distanceBar1;
    public Image distanceBar2;
    float currentDistance;
    public GameObject player;

    public Material blue;
    public Material red;
    public Material purple;
    public Material green;
    public Material white;


    // Update is called once per frame
    void FixedUpdate()
    {
        currentDistance = player.transform.position.z;
        if (distanceBar1.fillAmount < 1000)
        {
        distanceBar1.fillAmount = currentDistance / 1000;
        distanceBar2.GetComponent<Image>().material = white;
        }
        if (currentDistance > 1000 && currentDistance < 2000)
        {
            distanceBar1.fillAmount = (currentDistance -1000) / 1000;
            distanceBar1.GetComponent<Image>().material = blue;
            distanceBar2.GetComponent<Image>().material = null;
        }
        if (currentDistance > 2000 && currentDistance < 3000)
        {
            distanceBar1.fillAmount = (currentDistance - 2000) / 1000;
            distanceBar1.GetComponent<Image>().material = purple;
            distanceBar2.GetComponent<Image>().material = blue;
        }
        if (currentDistance > 3000 && currentDistance < 4000)
        {
            distanceBar1.fillAmount = (currentDistance - 3000) / 1000;
            distanceBar1.GetComponent<Image>().material = red;
            distanceBar2.GetComponent<Image>().material = purple;
        }
        if (currentDistance > 4000 && currentDistance < 5000)
        {
            distanceBar1.fillAmount = (currentDistance - 4000) / 1000;
            distanceBar1.GetComponent<Image>().material = green;
            distanceBar2.GetComponent<Image>().material = red;
        }
    }
}
