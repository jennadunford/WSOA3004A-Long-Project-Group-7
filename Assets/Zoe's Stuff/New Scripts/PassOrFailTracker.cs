using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PassOrFailTracker : MonoBehaviour
{
    [SerializeField]
    private GameObject clock;
    [SerializeField]
    private GameObject calenderImage;
    [SerializeField]
    private GameObject dayOfWeekDis;
    [SerializeField]
    private GameObject patronScript;

    [SerializeField]
    private Sprite placeholderIMG;
    [SerializeField]
    private Sprite passIMG;
    [SerializeField]
    private Sprite failIMG;

    [SerializeField]
    private TMP_Text patronsServed;


    [SerializeField]
    private Image mon;
    [SerializeField]
    private Image tues;
    [SerializeField]
    private Image wed;
    [SerializeField]
    private Image thurs;
    [SerializeField]
    private Image fri;
    [SerializeField]
    private Image sat;
    [SerializeField]
    private Image sun;


    private bool appeared = true;



    private Image[] daysWeek = new Image[7];

    private void Start()
    {
        daysWeek[0] = mon;
        daysWeek[1] = tues;
        daysWeek[2] = wed;
        daysWeek[3] = thurs;
        daysWeek[4] = fri;
        daysWeek[5] = sat;
        daysWeek[6] = sun;
    }

    private void Update()
    {
        patronsServed.text = patronScript.GetComponent<PatronScript>().patronsServed.ToString();
        
        if (!clock.GetComponent<ClockController>().dayTime && !appeared)
        {
            Calculations();
            StartCoroutine(Calender());
        }

        if (clock.GetComponent<ClockController>().dayTime)
        {
            appeared = false;
        }
    }

    private IEnumerator Calender()
    {
        calenderImage.SetActive(true);

        yield return new WaitForSeconds(2);

        calenderImage.SetActive(false);
        appeared = true;
    }

    private void Calculations()
    {
        if (int.Parse(clock.GetComponent<ClockController>().dailyGoal.text) <= patronScript.GetComponent<PatronScript>().patronsServed)
        {
            daysWeek[dayOfWeekDis.GetComponent<WeekdayManager>().dayNum].GetComponent<Image>().sprite = passIMG;
        }
        else
        {
            daysWeek[dayOfWeekDis.GetComponent<WeekdayManager>().dayNum].GetComponent<Image>().sprite = failIMG;
        }
    }
}
