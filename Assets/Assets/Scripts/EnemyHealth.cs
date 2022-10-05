using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public GameObject damText;
    public int health = 5;
    public GameObject droppedItem;

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
