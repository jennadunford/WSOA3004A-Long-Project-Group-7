using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookInteractionManager : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private CanvasGroup trialCanvasGroup;

    [SerializeField]
    private Canvas dragCanvas;

    [System.NonSerialized]
    public GameObject prevParent;

    private void Start()
    {
        trialCanvasGroup = gameObject.GetComponent<CanvasGroup>();
        prevParent = transform.parent.gameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {
        gameObject.GetComponent<RectTransform>().position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        trialCanvasGroup.blocksRaycasts = false;
        transform.parent = dragCanvas.transform;
        //this.gameObject.GetComponent<Transform>().localScale = new Vector3(1f, 1, 1f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        trialCanvasGroup.blocksRaycasts = true;
        transform.parent = prevParent.transform;
        //transform.localScale = new Vector3(1, 1, 1);
    }
}