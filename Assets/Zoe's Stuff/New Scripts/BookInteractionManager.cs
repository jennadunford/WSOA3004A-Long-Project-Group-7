using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookInteractionManager : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    [SerializeField]
    private GameObject inventoryManager;

    public GameObject prefab;

    public bool inInvent = false;
    private CanvasGroup trialCanvasGroup;

    private void Start()
    {
        trialCanvasGroup = gameObject.GetComponent<CanvasGroup>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        trialCanvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        trialCanvasGroup.blocksRaycasts = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!inInvent && !inventoryManager.GetComponent<InventoryManager>().inventFull)
        {
            inventoryManager.GetComponent<InventoryManager>().intakeBook = prefab;
            inventoryManager.GetComponent<InventoryManager>().intakeNum++;
            inInvent = true;
            Destroy(gameObject);
        }        
    }
}