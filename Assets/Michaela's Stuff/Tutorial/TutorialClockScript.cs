using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialClockScript : MonoBehaviour
{
    public delegate void DayChange();
    public static event DayChange OnDayChanged;
    public float duration = 360;

    public TMP_Text dailyGoal;

    [SerializeField]
    private GameObject popUp;

    [SerializeField]
    private GameObject weekdayDisplay;

    [SerializeField]
    private GameObject passFailTrack;

    [SerializeField]
    private GameObject background;

    private float timePassed = 0;
    private float speed = 2.5f;
    public float modifier;

    public AudioSource morning;
    public int currentGoal;

    public bool dayTime;
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
            if (GameObject.FindGameObjectWithTag("Patron") != null)
            {
                Destroy(GameObject.FindGameObjectWithTag("Patron"));
            }
        }
        else
        {
            popUp.SetActive(false);
        }

        if (modifier < -270 && !increaseDay)
        {
            //weekdayDisplay.GetComponent<WeekdayManager>().dayNum++;
            increaseDay = true;
            //OnDayChanged?.Invoke();
            NewDay();
            morning.Play();

        }

        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum == 6 && modifier < -90 && modifier > -180)
        {
            if (passFailTrack.GetComponent<PassOrFailTracker>().daysFailed >= 4)
            {
                Debug.Log("failure");
            }
        }


        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 < 0)
        {
            currentGoal = 1;
            dailyGoal.text = "1";
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

        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 0 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 1)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;

        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 0 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 1)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;

        }

        //Teusday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 1 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 5)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;

        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 1 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 5)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;

        }


        //Wednesday 
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 2 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 7)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;

        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 2 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 7)
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
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 4 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 7)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;

        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 4 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 7)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;

        }


        //Saturday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 5 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 9)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
            dailyGoal.text = "11";
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 5 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 9)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
            dailyGoal.text = "11";
        }


        //Sunday
        if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 6 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed >= 11)
        {
            Debug.Log("Success");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysPassed++;
        }
        else if (weekdayDisplay.GetComponent<WeekdayManager>().dayNum - 1 == 6 && GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed < 11)
        {
            Debug.Log("Failure");
            GameObject.Find("Main Camera").GetComponent<PatronScript>().patronsServed = 0;
            GameObject.Find("Main Camera").GetComponent<PatronScript>().daysFailed++;
        }
    }
}
