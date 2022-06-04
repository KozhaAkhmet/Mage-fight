using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float areaWidth;
    [SerializeField]
    private float areaHeight;
    [SerializeField]
    private float repeatRate = 2;
    
    public Masked_Man enemyObject;
    private Vector3 spawnPosition;
    private GameObject spawnPoint;
    void Start()
    {
        InvokeRepeating("Spawn", 0f, repeatRate);
        DebugArea();  // Draw Spawn Area 
        
    }

    void Update()
    {
        
    }

    private void Spawn()
    {
        spawnPosition.x = Random.Range(-areaWidth / 2 + transform.position.x, areaWidth / 2 + transform.position.x);
        spawnPosition.y = Random.Range(-areaHeight / 2 + transform.position.y, areaHeight / 2 + transform.position.y);
        spawnPosition.z = 0;
        Instantiate(enemyObject, spawnPosition, Quaternion.identity);
    }
    private void DebugArea()
    {
        Debug.DrawLine(transform.position + new Vector3(areaWidth / 2, areaHeight / 2), transform.position + new Vector3(-areaWidth / 2, areaHeight / 2),new Color(1, 0, 0, 1), 10f); // Top Border
        Debug.DrawLine(transform.position + new Vector3(areaWidth / 2, areaHeight / 2), transform.position + new Vector3(areaWidth / 2, -areaHeight / 2), new Color(1, 0, 0, 1), 10f);// Right Border
        Debug.DrawLine(transform.position + new Vector3(areaWidth / 2, -areaHeight / 2), transform.position - new Vector3(areaWidth / 2, areaHeight / 2), new Color(1, 0, 0, 1), 10f);// Bottom Border
        Debug.DrawLine(transform.position - new Vector3(areaWidth / 2, areaHeight / 2), transform.position + new Vector3(-areaWidth / 2, areaHeight / 2), new Color(1, 0, 0, 1), 10f);// Left Border
    }
    
}
