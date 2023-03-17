using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 tagetPost;
    public float Xdistance;

    public float speed;
    public float maxWidth;
    public float minWidth;

    private void Start()
    {
        tagetPost = transform.position; 
    }
    private void Update()
    {
        if (GameManager.Instance.isGameOver) return;

        transform.position = Vector2.MoveTowards(transform.position,tagetPost, speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) )
        {

            MoveRight();
            
        }
        if(transform.position.x < minWidth)
        {
            transform.position = new Vector3(minWidth, transform.position.y, transform.position.z);   
        }else if (transform.position.x > maxWidth) 
        { transform.position = new Vector3(maxWidth,transform.position.y, transform.position.z); }
    }
    public void MoveRight()
    {
        if(transform.position.x < maxWidth)
        {
            tagetPost = new Vector2(transform.position.x + Xdistance, transform.position.y);
            //Debug.Log("Right");
        }
        
    }
    public void MoveLeft() {
        if (transform.position.x > minWidth)
        {
            //Debug.Log("Left");
            tagetPost = new Vector2(transform.position.x - Xdistance, transform.position.y);
        }
       

    }
}
