using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RemoveFromInventory : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    [SerializeField]
    public GameObject prefab;

    private CanvasGroup canvasGroup;

    //I am not gonna comment this out because most of it is self explainatory
    private void Start()
    {
        canvasGroup = gameObject.GetComponent<CanvasGroup>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;//unless its over a book shelf
        canvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
}
