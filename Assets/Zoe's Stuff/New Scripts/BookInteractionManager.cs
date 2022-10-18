using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookInteractionManager : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public GameObject prefab;
    
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
        Debug.Log("fs");
    }
}