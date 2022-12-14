using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] AnimalArray;
     int AnimalIndex = 0;
    private float SpawnRangeX = 20;
    
    private float SpawnPosZ = 20;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);

        if (Input.GetKeyDown(KeyCode.S))
        {
            AnimalIndex = Random.Range(0, AnimalArray.Length);
            Instantiate(AnimalArray[AnimalIndex], spawnPos,
                AnimalArray[AnimalIndex].transform.rotation);
        }
        
    }
}
