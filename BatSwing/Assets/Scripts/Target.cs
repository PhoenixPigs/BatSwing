using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = true;
            }
        }
        if (other.CompareTag("Green"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = true;
                
            }
        }
        if (other.CompareTag("Purple"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = true;
            }
        }
        if (other.CompareTag("Blue"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = true;
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = false;
            }
        }
        if (other.CompareTag("Green"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = false;
            }
        }
        if (other.CompareTag("Purple"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = false;
            }
        }
        if (other.CompareTag("Blue"))
        {
            CubeMove objectScript = other.GetComponent<CubeMove>();
            if (objectScript != null)
            {
                objectScript.inTarget = false;
            }
        }
    }
}