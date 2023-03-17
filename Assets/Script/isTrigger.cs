using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour
{

    public GameObject playerDeadPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(Const.OBSTACLE_TAG))
        {

            GameManager.Instance.GameOver();


        }
    }
}
