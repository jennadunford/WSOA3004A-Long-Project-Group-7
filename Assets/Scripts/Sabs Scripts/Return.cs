using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Return : MonoBehaviour
{
 



    public void ReturnMe()
    {


        if (gameObject.GetComponentInParent<BookPile>().pile[0].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[0].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[1].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[1].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[2].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[2].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[3].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[3].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[4].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[4].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[5].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[5].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
        }






    }
}

