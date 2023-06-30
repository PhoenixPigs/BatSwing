using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWeapon : MonoBehaviour
{
    public ParticleSystem Red;
    public ParticleSystem Blue;
    public ParticleSystem Green;
    public ParticleSystem Purple;

    public ParticleSystem death;

    public Manager _manager;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Red.Play();
            StartCoroutine(AnimStop());

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                _manager.comboAm++;
                _manager.sliderChange();
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.sliderChange();

            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);

            }

        }




        if (Input.GetKeyDown(KeyCode.W))
        {
            Purple.Play();
            StartCoroutine(AnimStop());

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                _manager.comboAm++;
                _manager.sliderChange();
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.sliderChange();
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);

            }

        }



        if (Input.GetKeyDown(KeyCode.Q))
        {
            Blue.Play();
            StartCoroutine(AnimStop());

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Blue")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                _manager.comboAm++;
                _manager.sliderChange();
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Purple" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.sliderChange();
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);

            }

        }




        if (Input.GetKeyDown(KeyCode.R))
        {
            Green.Play();
            StartCoroutine(AnimStop());

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);
                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                _manager.comboAm++;
                _manager.sliderChange();
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Purple")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.sliderChange();
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * 1000, Color.white);

            }

        }

    }

    IEnumerator AnimStop()
    {
        yield return new WaitForSeconds(0.1f);
        Red.Stop();
        Green.Stop();
        Blue.Stop();
        Purple.Stop();

    }
}
