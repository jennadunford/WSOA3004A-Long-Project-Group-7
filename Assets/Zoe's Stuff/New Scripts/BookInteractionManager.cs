using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookInteractionManager : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public bool inInvent = false;
    private CanvasGroup trialCanvasGroup;

    [SerializeField]
    private Canvas dragCanvas;

    [SerializeField]
    private GameObject slot1;
    [SerializeField]
    private GameObject slot2;
    [SerializeField]
    private GameObject slot3;
    [SerializeField]
    private GameObject slot4;

    private GameObject[] slotsArray = new GameObject[4];

    private void Start()
    {
        trialCanvasGroup = gameObject.GetComponent<CanvasGroup>();

        slotsArray[0] = slot1;
        slotsArray[1] = slot2;
        slotsArray[2] = slot3;
        slotsArray[3] = slot4;
    }
    public void OnDrag(PointerEventData eventData)
    {
        //transform.position = Input.mousePosition;
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

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!inInvent)
        {
            for (int i = 0; slotsArray[i].transform.childCount == 0 && i < 4; i++)
            {
                this.gameObject.transform.parent = slotsArray[i].transform;
                this.gameObject.GetComponent<Transform>().position = slotsArray[i].GetComponent<Transform>().position;
                inInvent = true;
                

            }
        }
    }
}