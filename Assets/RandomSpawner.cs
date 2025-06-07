using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject[] myObjects;

    void Update()
    {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-300, 310), -27, Random.Range(-300, 310));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
    }
}
