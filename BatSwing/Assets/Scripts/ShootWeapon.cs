using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);
                Debug.Log("Miss");
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);
                Debug.Log("Miss");
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Blue")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Purple" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);
                Debug.Log("Miss");
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Destroy(hit.transform.gameObject);
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Purple")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);
                Debug.Log("Miss");
            }
        }
    }
}
