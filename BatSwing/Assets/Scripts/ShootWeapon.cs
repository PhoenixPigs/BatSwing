using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.VFX;

public class ShootWeapon : MonoBehaviour
{
    [Header("ShootEffect")]
    public VisualEffect Red;
    public VisualEffect Blue;
    public VisualEffect Green;
    public VisualEffect Purple;

    [Header("Explosion")]
    public ParticleSystem greenSpark;
    public ParticleSystem redSpark;
    public ParticleSystem purpleSpark;
    public ParticleSystem blueSpark;
    [Header(" ")]
    public VisualEffect greenExplosion;
    public VisualEffect redExplosion;
    public VisualEffect purpleExplosion;
    public VisualEffect blueExplosion;
    [Header("Audio")]
    public AudioSource shoot;
    [Header("Points")]
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
            //StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Red")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                ParticleSystem RedSpark = Instantiate(redSpark, hit.transform.position, Quaternion.identity);
                VisualEffect RedExplosion = Instantiate(redExplosion, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                Destroy(RedSpark, 1);
                Destroy(RedExplosion, 1);

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
            //StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Purple")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                ParticleSystem PurpleSpark = Instantiate(purpleSpark, hit.transform.position, Quaternion.identity);
                VisualEffect PurpleExplosion = Instantiate(purpleExplosion, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                Destroy(PurpleSpark, 1);
                Destroy(PurpleExplosion, 1);

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
            //StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Blue")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                ParticleSystem BlueSpark = Instantiate(blueSpark, hit.transform.position, Quaternion.identity);
                VisualEffect BlueExplosion = Instantiate(blueExplosion, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                Destroy(BlueSpark, 1);
                Destroy(BlueExplosion, 1);


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
            //StartCoroutine(AnimStop());
            ScreenShakeManager.instance.CameraShake(impulseSource);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity) && hit.transform.gameObject.tag == "Green")
            {
                CubeMove cubeHit = hit.transform.gameObject.GetComponent<CubeMove>();

                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                ParticleSystem GreenSpark = Instantiate(greenSpark, hit.transform.position, Quaternion.identity);
                VisualEffect GreenExplosion = Instantiate(greenExplosion, hit.transform.position, Quaternion.identity);
                Destroy(GreenExplosion, 1);
                Destroy(GreenSpark, 1);
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
