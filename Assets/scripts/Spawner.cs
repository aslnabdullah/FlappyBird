using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird BirdScript;
    public GameObject pipes;
    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
        
    }

  
    //we use this function for the time situation
    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {
            //for making pipes
            Instantiate(pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            //waiting a second for spawning
            yield return new WaitForSeconds(time);

        }
    }
}
