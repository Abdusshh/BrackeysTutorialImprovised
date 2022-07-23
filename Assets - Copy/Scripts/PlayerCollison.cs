using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    // this method work on collison as long as we have rigidbody and collider

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
            //collisionInfo.collider.name == "Obstacle" this is slower because there may be many names 
        {
            movement.enabled = false;// stops the movement
            FindObjectOfType<GameManager>().endGame();
        }        
    }
}
