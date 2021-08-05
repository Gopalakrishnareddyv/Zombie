using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform playerSpawnPoints;
    Transform[] spawnPoints;
    public bool reSpawn;
    // Start is called before the first frame update
    void Start()
    {

        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (reSpawn)
        {
            int i = Random.Range(1, spawnPoints.Length);
            Instantiate(playerPrefab, spawnPoints[i].position, Quaternion.identity);
            //transform.position = spawnPoints[i].transform.position;
            print(spawnPoints[i].transform.position);
            reSpawn = false;
        }

    }
    
}
