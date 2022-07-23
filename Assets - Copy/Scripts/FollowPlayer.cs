using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Transform is the reference we make for position
    public Transform player;
    public Vector3 offset; // stores 3 floats

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; 
        // transform with little 't' refers to the Transform of current object in this case our camera
        // offset moves the camera back
    }
}
