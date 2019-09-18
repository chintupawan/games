using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandom", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandom()
    {
        Vector3 pos =  new Vector3(Random.Range(-20,20), 0, 20);
        int index = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[index], pos, animalPrefabs[0].transform.rotation);
    }
}
