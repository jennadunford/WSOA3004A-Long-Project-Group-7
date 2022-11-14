using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    //This script will controll the movement of the elevator allowing the plyer to move to different levels in the game. 
    [SerializeField]
    bool playerOn=true;
    bool levelreached = true;
    public GameObject lift;
    float elevatorMoveSpeed;
    public GameObject player;
    public Transform parent;
    public int liftLevel=0;
    float levelPos = 4.849f;

    public GameObject leftcol;
    public GameObject rightcol;


    // Start is called before the first frame update
    void Start()
    {
        parent = this.gameObject.transform;

        leftcol.SetActive(false);
        rightcol.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOn == true)
        {

            if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
            {
                leftcol.SetActive(true);
                rightcol.SetActive(true);
                if (levelreached == true)
                {
                    if (liftLevel < 2)
                    {
                       
                        transform.DOMoveY(transform.position.y + levelPos, 1);
                        liftLevel += 1;
                        levelreached = false;
                        StartCoroutine(LiftTime());
                        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
                    }
                }




            }

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                leftcol.SetActive(true);
                rightcol.SetActive(true);

                if (levelreached == true)
                {
                    if (liftLevel >= 1)
                    {
                       
                        transform.DOMoveY(transform.position.y - levelPos, 1);
                        liftLevel -= 1;
                        levelreached = false;
                        StartCoroutine(LiftTime());
                        
                        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
                    }
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


      
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        playerOn = false;
        player.transform.SetParent(null);
     
    }

    IEnumerator LiftTime()
    {
        yield return new WaitForSeconds(1.1f);
        levelreached = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = true;
        leftcol.SetActive(false);
        rightcol.SetActive(false);
    }
}
