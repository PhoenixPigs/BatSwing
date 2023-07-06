using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class ShootWeapon : MonoBehaviour
{
    public ParticleSystem Red;
    public ParticleSystem Blue;
    public ParticleSystem Green;
    public ParticleSystem Purple;

    public ParticleSystem death;

    public AudioSource shoot;

    public float magniturd;
    public float longth;

    public GameObject points;

    public Manager _manager;
    private CinemachineImpulseSource impulseSource;

    private void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Red.Play();
            shoot.Play();
            StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);

                if (cubeHit.inTarget == true)
                {

                _manager.comboAm++;
                _manager.sliderChange();
                }
                else
                {
                    _manager.comboAm = 0;
                    _manager.shaderOff();
                    _manager.comboBar.maxValue = 10;
                    _manager.sliderChange();
                }
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                GameObject pointz = Instantiate(points, hit.transform.position, Quaternion.identity) as GameObject;
                pointz.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = "+" + 100 * _manager.comboMul;
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.shaderOff();
                _manager.comboBar.maxValue = 10;
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
            shoot.Play();
            StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);

                if (cubeHit.inTarget == true)
                {

                    _manager.comboAm++;
                    _manager.sliderChange();
                }
                else
                {
                    _manager.comboAm = 0;
                    _manager.shaderOff();
                    _manager.comboBar.maxValue = 10;
                    _manager.sliderChange();
                }
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                GameObject pointz = Instantiate(points, hit.transform.position, Quaternion.identity) as GameObject;
                pointz.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = "+" + 100 * _manager.comboMul;
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.shaderOff();
                _manager.comboBar.maxValue = 10;
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
            shoot.Play();
            StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Blue")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);

                if (cubeHit.inTarget == true)
                {

                    _manager.comboAm++;
                    _manager.sliderChange();
                }
                else
                {
                    _manager.comboAm = 0;
                    _manager.shaderOff();
                    _manager.comboBar.maxValue = 10;
                    _manager.sliderChange();
                }
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                GameObject pointz = Instantiate(points, hit.transform.position, Quaternion.identity) as GameObject;
                pointz.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = "+" + 100 * _manager.comboMul;
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Purple" || hit.transform.gameObject.tag == "Green")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.shaderOff();
                _manager.comboBar.maxValue = 10;
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
            shoot.Play();
            StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Green")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                Instantiate(death, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);

                if (cubeHit.inTarget == true)
                {

                _manager.comboAm++;
                _manager.sliderChange();
                }
                else
                {
                    _manager.comboAm = 0;
                    _manager.shaderOff();
                    _manager.comboBar.maxValue = 10;
                    _manager.sliderChange();
                }
                _manager.scoreAm = _manager.scoreAm + 100 * _manager.comboMul;
                GameObject pointz = Instantiate(points, hit.transform.position, Quaternion.identity) as GameObject;
                pointz.transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = "+" + 100 * _manager.comboMul;
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red" || hit.transform.gameObject.tag == "Blue" || hit.transform.gameObject.tag == "Purple")
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
                _manager.comboAm = 0;
                _manager.shaderOff();
                _manager.comboBar.maxValue = 10;
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
