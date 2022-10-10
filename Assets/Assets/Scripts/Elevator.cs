using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    //This script will controll the movement of the elevator allowing the plyer to move to different levels in the game. 
    [SerializeField]
    bool playerOn=false;
    public GameObject lift;
    float elevatorMoveSpeed;
    public GameObject player;
    public Transform parent;
    public int liftLevel=0;
    
    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOn == true)
        {
            
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (liftLevel<=0)
                {
                    lift.transform.position = new Vector2(lift.transform.position.x, (lift.transform.position.y + 5.5f));
                    liftLevel +=1;
                }
               



                



            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                
                if (liftLevel >=0)
                {
                    lift.transform.position = new Vector2(lift.transform.position.x, (lift.transform.position.y - 5.5f));
                    liftLevel -= 1;
                }

            }
        }
    }

    //if the player is on the lift then the game will acknowlegde that they are on the lift.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerOn = true;
            player.transform.SetParent(parent);

        }
        else
        {
            playerOn = false;
           
        }

      
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        playerOn = false;
        player.transform.SetParent(null);
    }
}