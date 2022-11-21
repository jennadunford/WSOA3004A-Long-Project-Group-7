using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEndScript : MonoBehaviour
{
    public GameObject weekdayDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 0 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 1)
        {
            Debug.Log("TutorialEnded");

        }
    }
}
