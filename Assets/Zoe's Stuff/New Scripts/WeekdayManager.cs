using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeekdayManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text displayTxt;

    public int dayNum = 0;
    
    private string[] weekDays = new string[7];

    private string one = "Mon";
    private string two = "Tues";
    private string three = "Wed";
    private string four = "Thur";
    private string five = "Fri";
    private string six = "Sat";
    private string seven = "Sun";

    // Start is called before the first frame update
    void Start()
    {
        weekDays[0] = one;
        weekDays[1] = two;
        weekDays[2] = three;
        weekDays[3] = four;
        weekDays[4] = five;
        weekDays[5] = six;
        weekDays[6] = seven;

    }

    // Update is called once per frame
    void Update()
    {
        displayTxt.text = weekDays[dayNum];
    }
}
