using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    [SerializeField] private Transform players;

    private void Update()
    {
        if(players)
        transform.position = new Vector3(players.position.x, players.position.y, transform.position.z);
    }
}
