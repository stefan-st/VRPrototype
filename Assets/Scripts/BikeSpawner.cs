using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bikePrefab;
    public int bikesToSpawn = 10;
    void Start()
    {
        StartCoroutine(SpawnBike());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBike()
    {
        int count = 0;
        while (count < bikesToSpawn)
        {
            GameObject newBike = GameObject.Instantiate(bikePrefab, transform);
            Transform child = transform.GetChild(Random.Range(0, transform.childCount - 1));
            newBike.GetComponent<WaypointNavigator>().currWaypoint = child.GetComponent<Waypoint>();
            newBike.transform.position = child.position;

            yield return new WaitForEndOfFrame();
            count++;
        }
    }
}
