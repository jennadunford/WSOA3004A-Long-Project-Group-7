using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookInteractionManager : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public bool inInvent = false;
    private CanvasGroup trialCanvasGroup;

    [SerializeField]
    private Canvas dragCanvas;

    private void Start()
    {
        trialCanvasGroup = gameObject.GetComponent<CanvasGroup>();

        
    }
    public void OnDrag(PointerEventData eventData)
    {
        gameObject.GetComponent<RectTransform>().position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        trialCanvasGroup.blocksRaycasts = false;
        transform.parent = dragCanvas.transform;
        this.gameObject.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 0.7f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        trialCanvasGroup.blocksRaycasts = true;

    }
}