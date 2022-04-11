using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bikePrefab;
    void Start()
    {
        InvokeRepeating(nameof(SpawnBike), 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBike()
    {
        GameObject newBike = GameObject.Instantiate(bikePrefab, transform);
    }
}
