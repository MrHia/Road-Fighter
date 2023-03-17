using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadLoop : MonoBehaviour
{
    public float speed;
    public Transform road_1;
    public Transform road_2;


    float m_ySize;


    private void Awake()
    {
        m_ySize = road_1.GetComponent<BoxCollider2D>().size.y * road_1.transform.localScale.y ;

        road_1.position = new Vector3(0, -1, 0);
        road_2.position = new Vector3(road_1.position.x,road_1.position.y + m_ySize, 0);

    }
    private void Update()
    {
        if (GameManager.Instance.isGameOver) return;

        transform.Translate(Vector3.down*speed*Time.deltaTime);

        if(road_1.position.y <= -m_ySize)
        {
            road_1.position = new Vector3 (road_2.position.x,road_2.position.y+m_ySize,0);

            Transform temp = road_1;

            road_1 = road_2;
            road_2 = temp;

        }
    }
}
