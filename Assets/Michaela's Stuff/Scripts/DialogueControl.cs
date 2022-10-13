using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    public GameObject DialogueOne;
    public GameObject DialogueTwo;
    public GameObject Patron;
    public GameObject BookOne;
    public GameObject BookInventory;

    void Start()
    {
        DialogueOne.SetActive(true);
        DialogueTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == Patron)
        {
            DialogueOne.SetActive(false);
        }

        if (collision.gameObject == Patron && BookOne == false)
        {
            //DialogueTwo.SetActive(true);
            BookInventory.SetActive(false);
        }
    }
}
