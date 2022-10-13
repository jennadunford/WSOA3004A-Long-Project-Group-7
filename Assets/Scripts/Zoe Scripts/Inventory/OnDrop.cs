using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnDrop : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameObject inventory;

    [SerializeField]
    private GameObject child;

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            child = Instantiate(eventData.pointerDrag.GetComponent<RemoveFromInventory>().prefab, gameObject.transform.position, Quaternion.Euler(0, 0, 0), gameObject.transform);
            child.GetComponent<CanvasGroup>().blocksRaycasts = true;
            eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
            inventory.GetComponent<InventoryManager>().inventContent--;
            Destroy(eventData.pointerDrag);
        }
    }
}
