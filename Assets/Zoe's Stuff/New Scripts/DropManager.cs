using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropManager : MonoBehaviour, IDropHandler
{
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (this.gameObject.transform.parent.tag.Contains(eventData.pointerDrag.tag.ToString()))
            {
                Debug.Log(this.gameObject.transform.parent.tag);
                eventData.pointerDrag.transform.parent = this.gameObject.transform;
                eventData.pointerDrag.transform.localScale = new Vector3(1, 1, 1);
                eventData.pointerDrag.transform.eulerAngles = new Vector3(0, 0, 0);
                eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
                
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;

                eventData.pointerDrag.GetComponent<BookInteractionManager>().prevParent = this.gameObject;
            }
        }
    }
}
