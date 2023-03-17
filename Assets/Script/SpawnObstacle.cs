using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    float time;
    public float maxWidth;
    public float minWidth;

    public Vector3[] pointSpawn;

    public GameObject obstaclePrefab;
    GameObject obstacle;
    private void Start()
    {
        obstacle = Instantiate(obstaclePrefab);
    }

    private void Update()
    {
        if(GameManager.Instance.isGameOver)
        {
            return;
        }

        if (time > GameManager.Instance.spawnTime)
        {
            obstacle = Instantiate(obstaclePrefab);
            //obstacle.transform.position = transform.position + new Vector3(Random.Range(maxWidth, minWidth),0, 0);
            obstacle.transform.position = pointSpawn[Random.Range(0,pointSpawn.Length)];
            time = 0;
        }
        time += Time.deltaTime;
    }
}
