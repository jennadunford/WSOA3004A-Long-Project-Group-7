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
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[1].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[1].transform;
            
            this.gameObject.transform.position = this.gameObject.transform.parent.position;

            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[2].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[2].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;

            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[3].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[3].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[4].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[4].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[5].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[5].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[6].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[6].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[7].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[7].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[8].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[8].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[9].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[9].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[10].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[10].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }       
        else if (gameObject.GetComponentInParent<BookPile>().pile[11].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[11].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[12].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[12].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[13].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[13].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[14].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[14].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[15].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[15].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[16].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[16].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[17].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[17].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[18].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[18].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[19].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[19].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[20].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[20].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[21].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[21].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[22].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[22].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[23].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[23].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[24].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[24].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[25].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[25].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[26].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[26].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[27].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[27].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[28].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[28].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }
        else if (gameObject.GetComponentInParent<BookPile>().pile[29].GetComponent<RemoveFromPile>().isUsed == false)
        {
            this.gameObject.transform.parent = gameObject.GetComponentInParent<BookPile>().pile[29].transform;
            this.gameObject.transform.position = this.gameObject.transform.parent.position;
            this.gameObject.SetActive(false);
        }






    }
}

