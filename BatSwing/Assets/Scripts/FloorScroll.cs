using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScroll : MonoBehaviour
{

    public GameObject groundTile;
    public Vector3 nextSpawnPoint;
    public Transform spawnPo;
    //public Pause _pause;
    private void Awake()
    {
   //     _pause = FindObjectOfType<Pause>();
        nextSpawnPoint = new Vector3(0, 0, gameObject.transform.position.z + 200);
        
    }
    private void Update()
    {
    //        if (_pause.GetIsPaused()) { return; }
    }
    public void SpawnTile()
    {
        //nextSpawnPoint = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 10);
        //nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
    }

}
