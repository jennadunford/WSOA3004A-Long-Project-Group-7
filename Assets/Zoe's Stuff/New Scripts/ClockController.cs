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
        Debug.Log("Oublished Event");
        //set slots active
        popUp.SetActive(false);
        weekdayDisplay.GetComponent<WeekdayManager>().dayNum++;
        increaseDay = true;
        timePassed = duration/4 * 3;
    }
}
