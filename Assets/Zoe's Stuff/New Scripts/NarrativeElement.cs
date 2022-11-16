using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NarrativeElement : MonoBehaviour
{
    private GameObject[] elements = new GameObject[5];

    [SerializeField]
    private GameObject one;
    [SerializeField]
    private GameObject two;
    [SerializeField]
    private GameObject three;
    [SerializeField]
    private GameObject four;
    [SerializeField]
    private GameObject five;

    private int pressed;
    int move;

    private void Start()
    {
        elements[0] = one;
        elements[1] = two;
        elements[2] = three;
        elements[3] = four;
        elements[4] = five;
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            elements[pressed].SetActive(false);
            elements[pressed + 1].SetActive(true);
            move++;
            pressed++;
          
        }

        if (move >= 4)
        {
            SceneManager.LoadScene("ArtTest");
        }
    }


}
