using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropManager : MonoBehaviour, IDropHandler
{
    private GameObject child;
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.tag == "Book")
            {
                child = Instantiate(eventData.pointerDrag.GetComponent<BookInteractionManager>().prefab, gameObject.transform.position, Quaternion.Euler(0, 0, 0), gameObject.transform);
                eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                Destroy(eventData.pointerDrag);
                child.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            
        }
    }
}
