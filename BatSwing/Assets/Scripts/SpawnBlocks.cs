using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{

    public Transform[] spawns;
    public GameObject[] blocks;

    public int var1;
    public int var2;

  //  public Pause _pause;
    private void Awake()
    {
    //    _pause = FindObjectOfType<Pause>();
    }

    void Update()
    {
    //        if (_pause.GetIsPaused()) { return; }
    }
    void Start()
    {
        StartCoroutine(SpawnTimer());
    }
    IEnumerator SpawnTimer()
    {
        yield return new WaitForSeconds(Random.Range(var1, var2));
        int randomBlockIndex = Random.Range(0, blocks.Length);
        int randomSpawnIndex = Random.Range(0, spawns.Length);

        Instantiate(blocks[randomBlockIndex], spawns[randomSpawnIndex].position, spawns[randomSpawnIndex].rotation);
        StartCoroutine(SpawnTimer());
    }
}
