using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class NewBookScipt : MonoBehaviour, IPointerClickHandler
{

    public bool full = false;
    private CanvasGroup trialCanvasGroup;

    [SerializeField]
    private Canvas dragCanvas;

    [SerializeField]
    private GameObject rackSlot1;
    [SerializeField]
    private GameObject rackSlot2;
    [SerializeField]
    private GameObject rackSlot3;
    [SerializeField]
    private GameObject rackSlot4;

    private GameObject[] rackSlotsArray = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {

        rackSlotsArray[0] = rackSlot1;
        rackSlotsArray[1] = rackSlot2;
        rackSlotsArray[2] = rackSlot3;
        rackSlotsArray[3] = rackSlot4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!full)
        {
            for (int i = 0; rackSlotsArray[i].transform.childCount == 0 && i < 4; i++)
            {
                this.gameObject.transform.parent = rackSlotsArray[i].transform;
                this.gameObject.GetComponent<Transform>().position = rackSlotsArray[i].GetComponent<Transform>().position;
                full = true;


            }
        }
    }
}
