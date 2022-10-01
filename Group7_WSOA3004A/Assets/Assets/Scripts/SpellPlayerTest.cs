using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellPlayerTest : MonoBehaviour
{

    //This will be one of the spells, it will "Stun" the enemy and make them move slower alwoing the player to do stuff like heal? 

    float spellCoolDown;
    public float spellCDTimer;

    //base weapon values
    public Transform weaponPos;
    public float weaponRange;
    public LayerMask enemyLayer;
    public int weaponDamage =0;
 
    // Update is called once per frame
    void Update()
    {
        if (spellCoolDown <= 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Cast");
                Collider2D[] enemies = Physics2D.OverlapCircleAll(weaponPos.position, weaponRange, enemyLayer);
                for (int i = 0; i < enemies.Length; i++)
                {
                    if(enemies[i].GetComponent<EnemyAttack>().movementSpeed> 1)
                    {

                        
                        enemies[i].GetComponent<EnemyAttack>().movementSpeed -= 2;
                        //after a few seconds movement speed will go back to "3".

                    }

                    
                    Debug.Log(enemies[i].name);
                }

            }


            spellCoolDown = spellCDTimer;
        }
        else
        {
            spellCoolDown -= Time.deltaTime;
        }


    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(weaponPos.position, weaponRange);
    }
}
