using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    public delegate void DayChange();
    public static event DayChange OnDayChanged;
    [SerializeField]
    private float duration = 360;

    [SerializeField]
    private GameObject popUp;

    [SerializeField]
    private GameObject weekdayDisplay;

    private float timePassed = 0;
    private float speed = 2.5f;
    public float modifier;
    public bool dayTime = false;
    private bool increaseDay = false;

    private void Start()
    {
        timePassed = (duration * 3) / 4;
        increaseDay = true;
    }


    private void Update()
    {
        speed = 360 / duration;
        timePassed += Time.deltaTime;
        modifier = -timePassed * speed;

        if (modifier < -360)
        {
            timePassed = 0;
        }

        if (modifier < -90 && modifier > -180)
        {
            increaseDay = false;
        }

        this.gameObject.GetComponent<Transform>().eulerAngles = new Vector3(0, 0, modifier);

        if (modifier > -90 || modifier < -270)
        {
            dayTime = true;
        }
        else
        {
            dayTime = false;


        }

        if (!dayTime)
        {
            popUp.SetActive(true);
        }
        else
        {
            popUp.SetActive(false);
        }

        if (modifier < -270 && !increaseDay)
        {
            weekdayDisplay.GetComponent<WeekdayManager>().dayNum++;
            increaseDay = true;
        }
    }

    public void NewDay()
    {
        OnDayChanged?.Invoke();
        //Debug.Log("Oublished Event");
        popUp.SetActive(false);
        weekdayDisplay.GetComponent<WeekdayManager>().dayNum++;
        increaseDay = true;
        timePassed = duration / 4 * 3;


        //This block of code will check to see if the player has completed the daily goal.
        //The number at the end of the if statement is the number of Patrons the player needs to help in order to succeed the day

        //Monday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum -1 == 0 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 2)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum -1 == 0 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 2)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }

        //Teusday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum -1 == 1 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 3)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum -1 == 1 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 3)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }

        //Wednesday 
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 2 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 4)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 2 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 4)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }

        //Thursday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 3 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 5)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 3 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 5)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;

        }

        //Friday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 4 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 6)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 4 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 6)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }

        //Saturday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 5 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 7)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 5 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 7)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }

        //Sunday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 6 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 8)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 6 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 8)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }
    }


}
