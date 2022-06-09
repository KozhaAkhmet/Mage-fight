using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waipoint_Follower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaipointIndex = 0;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaipointIndex].transform.position, transform.position) < .1f)
        {
            currentWaipointIndex++; 
            if(currentWaipointIndex >= waypoints.Length)
            {
                currentWaipointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaipointIndex].transform.position, Time.deltaTime * speed);
    }
}
