using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellSlots : MonoBehaviour
{
    [SerializeField]
    private Sprite openBook;
    [SerializeField]
    private Sprite closedBook;

    [SerializeField]
    private GameObject bookOne;
    [SerializeField]
    private GameObject bookTwo;
    [SerializeField]
    private GameObject bookThree;

    private bool oneCast = false;
    private bool twoCast = false;
    private bool threeCast = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (oneCast && twoCast && threeCast)
            {
                Debug.Log("No More Spells");
            }
            else if (oneCast && twoCast)
            {
                threeCast = true;
                bookThree.GetComponent<Image>().sprite = closedBook;
            }
            else if (oneCast)
            {
                twoCast = true;
                bookTwo.GetComponent<Image>().sprite = closedBook;
            }
            else
            {
                oneCast = true;
                bookOne.GetComponent<Image>().sprite = closedBook;
            }
        }
    }
}
