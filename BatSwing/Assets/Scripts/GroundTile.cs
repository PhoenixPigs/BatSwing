using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    [SerializeField] FloorScroll _floorScroll;

    // Start is called before the first frame update
   // public Pause _pause;
   // private void Awake()
   // {
   //     _pause = FindObjectOfType<Pause>();
    //}
    void Start()
    {
        _floorScroll = GameObject.FindObjectOfType<FloorScroll>();
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

        Destroy(gameObject, 2);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _floorScroll.SpawnTile();

        }
    }

    // Update is called once per frame
    void Update()
    {
   //         if (_pause.GetIsPaused()) { return; }
        
    }
}
