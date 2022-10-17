using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFromPile : MonoBehaviour
{
    //This script will check if the slot is being used or not and provide information to the "BookPile" script.

   public BookPile bookPile;
    public bool isUsed =false;
    

    public void RemoveMe()
    {
        isUsed = false;
    }
}
