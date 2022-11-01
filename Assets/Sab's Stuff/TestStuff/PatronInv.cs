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
            if (eventData.pointerDrag.tag == bookRequestCategory.tag)
            {
                eventData.pointerDrag.transform.parent = this.gameObject.transform;
                eventData.pointerDrag.transform.localScale = new Vector3(1, 1, 1);
                eventData.pointerDrag.transform.eulerAngles = new Vector3(0, 0, 0);
                eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
                bookRequestCategory.GetComponentInParent<PatRequest>().PatronServed();
                Debug.Log("Correct");
            }
        }
    }
}
