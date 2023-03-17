using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    //public float speed;

    Rigidbody2D rb;

    public GameObject[] Skin;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        Skin[Random.Range(0, Skin.Length)].SetActive(true);
    }
    private void Update()
    {
        rb.velocity = Vector2.down * GameManager.Instance.speedObstancle;
    }

}
