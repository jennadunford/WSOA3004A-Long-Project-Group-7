using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //float attackCoolDown;
    //public float attackCDTimer;

    ////base weapon values
    //public Transform weaponPos;
    //public float weaponRange;
    //public LayerMask enemyLayer;
    //public int weaponDamage;

    //private void Start()
    //{
    //    weaponDamage = 1;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(attackCoolDown <= 0)
    //    {
    //        if (Input.GetMouseButton(0))
    //        {
    //            Debug.Log("Swing");
    //            Collider2D[] enemies = Physics2D.OverlapCircleAll(weaponPos.position, weaponRange, enemyLayer);
    //            for (int i = 0; i< enemies.Length; i++)
    //            {
    //                enemies[i].GetComponent<EnemyHealth>().health -= weaponDamage;
    //                enemies[i].GetComponent<EnemyHealth>().ShowDamageTaken();
    //                Debug.Log(enemies[i].name);
    //            }
              
    //        }


    //        attackCoolDown = attackCDTimer;
    //    }
    //    else
    //    {
    //        attackCoolDown -= Time.deltaTime;
    //    }
    //}

    //void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.green;
    //    Gizmos.DrawWireSphere(weaponPos.position, weaponRange);
    //}
}
