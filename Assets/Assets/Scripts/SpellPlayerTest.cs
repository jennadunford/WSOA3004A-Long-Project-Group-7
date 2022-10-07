using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellPlayerTest : MonoBehaviour
{

    //This will be one of the spells, it will "Stun" the enemy and make them move slower alwoing the player to do stuff like heal? 

    float spellCoolDown;
    float spellCoolDown1;
    float spellCoolDown2;
    float spellCoolDown3;
    public float spellCDTimer;
    public float spellCDTimer1;
    public float spellCDTimer2;
    public float spellCDTimer3;

    public bool rageSpellReady=true;
    //base weapon values
    public Transform weaponPos;
    public float weaponRange;
    public LayerMask enemyLayer;
    public int weaponDamage =0;
    public GameObject spellVisualiser;
    public GameObject player;

    public PlayerAttack playerAttack;
    
 
    // Update is called once per frame
    void Update()
    {
        if (spellCoolDown <= 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //spellVisualiser.SetActive(true);
                StartCoroutine(SpellVis());

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


        //NEXT SPELL
        //if the rage spell is available.
        if (rageSpellReady==true)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                //player can't use the spell again
                rageSpellReady = false;
                //Start the cooldown for the rage spell.
                StartCoroutine(RageSpellTime());

                player.GetComponent<PlayerController>().weaponDamage += 2;
            }


            spellCoolDown1 = spellCDTimer1;
        }
        else
        {
            spellCoolDown1 -= Time.deltaTime;
        }






    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(weaponPos.position, weaponRange);
    }


    IEnumerator SpellVis()
    {
        yield return new WaitForSeconds(0.3f);
        //spellVisualiser.SetActive(false);

    }

    IEnumerator RageSpellTime()
    {
        yield return new WaitForSeconds(5f);
        rageSpellReady = true;
        player.GetComponent<PlayerAttack>().weaponDamage =1;
        StartCoroutine(RageCooldownTime());
        
       // spellVisualiser.SetActive(false);

    }

    IEnumerator RageCooldownTime()
    {
        yield return new WaitForSeconds(5f);
        rageSpellReady = true;
       

        // spellVisualiser.SetActive(false);

    }


}
