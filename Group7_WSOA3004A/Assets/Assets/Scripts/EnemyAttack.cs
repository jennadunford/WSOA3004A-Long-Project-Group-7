using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public GameObject raycastStart;
    public float direction;
    public float rayDistance;
    public float movementSpeed;
    


    public GameObject weapon;
    

    public bool attackReady=true;

    float attackCoolDown=5;

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
            //Debug.Log("Real Stuff");
            Debug.DrawRay(raycastStart.transform.position, Vector2.left  , Color.red);
            if (hit.collider.tag == "Player")
            {

                this.gameObject.transform.position = Vector2.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(player.transform.position.x + 1.5f, transform.position.y, player.transform.position.z), movementSpeed * Time.deltaTime);

                //attackReady = true;
                Attack();

            }


 
                //attack the player
              
                
                
                //change the animation to attack animation
               

                //wait a few seconds before 
               

            
        }
        else if(hit.collider == null)
        {
            //attackReady = false;
            //Debug.Log("I sleep");
            Debug.DrawRay(raycastStart.transform.position, Vector2.left  , Color.green);


            attackCoolDown = 5;
            StopCoroutine(AttackCoolDown());




        }

 
     

        
    }

    IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(attackCoolDown);
        Debug.Log("Attack");
        attackReady = true;

    }

    void Attack()
    {
        if (attackReady == true)
        {

            attackReady = false;
            player.gameObject.GetComponent<PlayerController>().playerHealth -= 1;
            StartCoroutine(AttackCoolDown());
            player.gameObject.GetComponent<PlayerController>().ShowEnemyDamageTaken();
        }
    }

}
