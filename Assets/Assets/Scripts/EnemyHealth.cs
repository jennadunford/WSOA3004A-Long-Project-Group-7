using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public GameObject damText;
    public int health = 0;
    public GameObject droppedItem;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

            Destroy(this.gameObject);

        }
        damText.GetComponentInChildren<TextMeshPro>().text = player.GetComponent<PlayerController>().weaponDamage.ToString();

    }
    
    public void ShowDamageTaken()
    {
        Instantiate(damText, this.gameObject.transform);
    }
    private void OnDestroy() 
    {
        //Instantiate(droppedItem, transform.position, transform.rotation);
    }

}
