using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropManager : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameObject inventoryManager;
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "Book")
            {
                eventData.pointerDrag.transform.parent = this.gameObject.transform;
                eventData.pointerDrag.transform.localScale = new Vector3(1, 1, 1);
                //child = Instantiate(eventData.pointerDrag.GetComponent<BookInteractionManager>().prefab, gameObject.transform.position, Quaternion.Euler(0, 0, 0), gameObject.transform);
                eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                //Destroy(eventData.pointerDrag);
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;

                if (eventData.pointerDrag.GetComponent<BookInteractionManager>().inInvent)
                {
                    inventoryManager.GetComponent<InventoryManager>().inventContent--;
                    eventData.pointerDrag.GetComponent<BookInteractionManager>().inInvent = false;
                }
            }
        }
    }
}
