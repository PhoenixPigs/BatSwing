using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool paused;
    public GameObject pauser;
    //public bool GetIsPaused() { return paused; }

    private void Start()
    {
        CanvasGroup pausercanvas = pauser.GetComponent<CanvasGroup>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TempPause();
        }
    }
    public void TempPause()
    {
        if (paused)
        {
            paused = false;
            Time.timeScale = 1;
            Debug.Log("UnPause");
            CanvasGroup pausercanvas = pauser.GetComponent<CanvasGroup>();
            pausercanvas.alpha = 0;
            pausercanvas.interactable = false;
            pausercanvas.blocksRaycasts = false;
        }
        else
        {
            Debug.Log("paused");
            paused = true;
            Time.timeScale = 0;
            pauser.SetActive(true);
            CanvasGroup pausercanvas = pauser.GetComponent<CanvasGroup>();
            pausercanvas.alpha = 1;
            pausercanvas.interactable = true;
            pausercanvas.blocksRaycasts = true;
        }
    }

}
