using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropOnTrolley : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (gameObject.transform.childCount < 4)
        {
            eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
            eventData.pointerDrag.transform.parent = this.gameObject.transform;
            eventData.pointerDrag.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            eventData.pointerDrag.GetComponent<BookInteractionManager>().prevParent = this.gameObject;
        }
    }
}
