using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeElement : MonoBehaviour
{
    private GameObject[] elements = new GameObject[4];

    [SerializeField]
    private GameObject one;
    [SerializeField]
    private GameObject two;
    [SerializeField]
    private GameObject three;
    [SerializeField]
    private GameObject four;

    private int pressed;

    private void Start()
    {
        elements[0] = one;
        elements[1] = two;
        elements[2] = three;
        elements[3] = four;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            elements[pressed].SetActive(false);
            elements[pressed + 1].SetActive(true);
            pressed++;
        }
    }


}
