using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Player Movement
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float runSpeed = 10.0f;
    bool isFacingRight=true;
    public int playerHealth=10;
    public GameObject enemyDamText;
    


    //Player Attack 
    float attackCoolDown;
    public float attackCDTimer;
    public Transform weaponPos;
    public LayerMask enemyLayer;
    public GameObject cooldownVisaliser;
    public float cooldownVisaliserAlpha;
    public Color Alpha;
   

    //Base weapon values
    public float weaponRange= 0.65f;
    public int weaponDamage = 1;
    public bool weaponEqipped=false;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        //Alpha = cooldownVisaliser.GetComponent<SpriteRenderer>().color;
       // cooldownVisaliserAlpha = Alpha.a;
    }


    void Update()
    {
        if (weaponEqipped == true)
        {
            if (attackCoolDown <= 0)
            {
                if (Input.GetMouseButton(0) | Input.GetKeyDown(KeyCode.V))
                {
                    Debug.Log("Swing");
                    Collider2D[] enemies = Physics2D.OverlapCircleAll(weaponPos.position, weaponRange, enemyLayer);
                    for (int i = 0; i < enemies.Length; i++)
                    {
                        enemies[i].GetComponent<EnemyHealth>().health -= weaponDamage;
                        enemies[i].GetComponent<EnemyHealth>().ShowDamageTaken();
                        Debug.Log(enemies[i].name);
                    }
                    //Alpha.a = 0;

                }


                attackCoolDown = attackCDTimer;
            }
            else
            {
                attackCoolDown -= Time.deltaTime;

                 


                //Alpha.a += Time.deltaTime;
                //cooldownVisaliser.GetComponent<SpriteRenderer>().color=Alpha;


            }


        }
    }


    private void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        if(horizontal>0 && !isFacingRight)
        {
            FlipCharcter();
        } else if (horizontal < 0 && isFacingRight)
        {
            FlipCharcter();
        }
 
    }

    void FlipCharcter()
    {
        Vector3 currScale = gameObject.transform.localScale;
        currScale.x *= -1;
        gameObject.transform.localScale = currScale;
        isFacingRight = !isFacingRight;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(weaponPos.position, weaponRange);
    }

    public void ShowEnemyDamageTaken()
    {
        Instantiate(enemyDamText, this.gameObject.transform);
    }
}
