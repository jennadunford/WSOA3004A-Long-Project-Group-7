using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject raycastStart;
    public float direction;
    public float rayDistance;
    LayerMask Player;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        direction=1;
        movementSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.position = Vector2.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), 6*Time.deltaTime);

        RaycastHit2D hit= Physics2D.Raycast(raycastStart.transform.position, Vector2.left, rayDistance);
        if (hit.collider != null)
        {
            Debug.Log("Real Stuff");
            Debug.DrawRay(raycastStart.transform.position, Vector2.left  , Color.red);
            this.gameObject.transform.position = Vector2.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),
    new Vector3(player.transform.position.x+1.5f, transform.position.y, player.transform.position.z), movementSpeed * Time.deltaTime);

            if (transform.position.x >= (player.transform.position.x + 1.5))
            {
                //attack the player
                //change the animation to attack animation
                //wait a few seconds before 


            }
        }
        else
        {
            Debug.Log("I sleep");
            Debug.DrawRay(raycastStart.transform.position, Vector2.left  , Color.green);
        }
    }
}
