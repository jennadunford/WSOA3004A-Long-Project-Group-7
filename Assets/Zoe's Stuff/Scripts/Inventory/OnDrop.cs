using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnDrop : MonoBehaviour, IDropHandler
{
    [SerializeField]
    private GameObject inventory;

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Instantiate(eventData.pointerDrag.GetComponent<RemoveFromInventory>().prefab, gameObject.transform.position, Quaternion.Euler(0, 0, 0), gameObject.transform);
            eventData.pointerDrag.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;
            inventory.GetComponent<InventoryManager>().inventContent--;
            Destroy(eventData.pointerDrag);
        }
    }
}
