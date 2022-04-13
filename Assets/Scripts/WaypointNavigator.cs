using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{
    BikeNavigatorController controller;
    public Waypoint currWaypoint;

    private void Awake()
    {
        controller = GetComponent<BikeNavigatorController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.SetDestination(currWaypoint.GetPosition());
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.reachedDestination)
        {
            currWaypoint = currWaypoint.nextWaypoint;
            Debug.Log(currWaypoint.name);
            controller.SetDestination(currWaypoint.GetPosition());
        }
    }
}
