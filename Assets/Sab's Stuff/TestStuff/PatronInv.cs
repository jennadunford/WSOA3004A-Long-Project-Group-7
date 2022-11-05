using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class PatronInv : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameObject inventoryManager;
    [SerializeField]
    GameObject bookRequestCategory;
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag==bookRequestCategory.tag)
            {
                eventData.pointerDrag.transform.parent = this.gameObject.transform;
                eventData.pointerDrag.transform.localScale = new Vector3(1, 1, 1);
                eventData.pointerDrag.transform.eulerAngles = new Vector3(0, 0, 0);
                eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
                eventData.pointerDrag.GetComponent<BookInteractionManager>().prevParent = this.gameObject;
                bookRequestCategory.GetComponentInParent<PatRequest>().PatronServed();
                Debug.Log("Correct");
                GameObject.Find("PatronSpawnPoint").GetComponent<BookPile>().AddBookToPile();
                GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed ++;


            }
        }

            //if (eventData.pointerDrag.tag == "Book" || eventData.pointerDrag.tag == "Adventure" || eventData.pointerDrag.tag == "Horror" || eventData.pointerDrag.tag == "Romance" || eventData.pointerDrag.tag == "Fantasy")
            //{
            //    eventData.pointerDrag.transform.parent = this.gameObject.transform;
            //    eventData.pointerDrag.transform.localScale = new Vector3(1, 1, 1);
            //    eventData.pointerDrag.transform.eulerAngles = new Vector3(0, 0, 0);
            //    eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
            //    eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
            //    eventData.pointerDrag.GetComponent<BookInteractionManager>().prevParent = this.gameObject;
            //    bookRequestCategory.GetComponentInParent<PatRequest>().PatronServed();
            //    Debug.Log("Correct");
            //}
        
    }
}
