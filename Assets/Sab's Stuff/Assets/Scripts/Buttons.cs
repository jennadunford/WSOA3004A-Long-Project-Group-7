using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

   

   //This serves as a place holder for adding the book to the players inventroy from the return pile.

    public void Rem()
    {

        this.transform.parent.GetComponent<RemoveFromPile>().isUsed = false;
        Destroy(this.gameObject);
    }
}
