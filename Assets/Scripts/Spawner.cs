using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float repeatRate = 2;
    private float timeStamp = 0f;

    public GameObject enemyObject;
    public Transform leftTopCorner;
    public Transform rightBottomCorner;

    private GameObject preSpawnObject;

    
    
    
    void Start()
    {
        //InvokeRepeating("Spawn", 0f, repeatRate);
    }

    void Update()
    {
        
        RandomSpawnPoint();
        if (timeStamp <= Time.time)
        {
            StartCoroutine(Spawn());
            timeStamp = Time.time + 2f;
        }
        
        
    }

    IEnumerator Spawn()
    {
        Vector3 randomPoint = RandomSpawnPoint();
        preSpawnObject = new GameObject();
        preSpawnObject.gameObject.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("2D Pixel Dungeon Asset Pack/interface/square_right_4");

        preSpawnObject.transform.position = randomPoint;

        yield return new WaitForSeconds(1f);
        Debug.Log("Spawn");
        Instantiate(enemyObject, randomPoint, Quaternion.identity);

        yield return new WaitForSeconds(0.2f);
        Destroy(preSpawnObject.gameObject);
        
    }
    
    public Vector3 RandomSpawnPoint()
    {
        Vector3 spawnPosition;
        spawnPosition.x = Random.Range(leftTopCorner.position.x - transform.position.x, rightBottomCorner.position.x - transform.position.x);
        spawnPosition.y = Random.Range(rightBottomCorner.position.y - transform.position.y, leftTopCorner.position.y - transform.position.y);

        spawnPosition.z = 0;

        spawnPosition += transform.position;
        return spawnPosition;
    }
    
    
    
}
