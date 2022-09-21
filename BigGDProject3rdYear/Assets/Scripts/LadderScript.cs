using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour
{
    ///This script will allow the player to climb up and down levels in the world, library and Dungeon alike.
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                //make upward movement possible
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                //make downward movement possible
            }
        }
    }
}
