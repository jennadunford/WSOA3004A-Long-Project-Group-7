using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    [SerializeField]
    private float duration = 360;

    [SerializeField]
    private GameObject popUp;

    [SerializeField]
    private GameObject weekdayDisplay;

    private float timePassed = 0;
    private float speed = 2.5f;
    private float modifier;
    private bool dayTime = false;
    private bool paused = false;
    private bool alreadyRan = false;

    private void Update()
    {
        if (!paused)
        {
            speed = 360 / duration;
            timePassed += Time.deltaTime;
            modifier = -timePassed * speed;

            if (modifier < -360)
            {
                timePassed = 0;
                alreadyRan = false;
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
        }
        
        if (modifier < -270 && modifier > -300 && !alreadyRan)
        {
            paused = true;
            alreadyRan = true;
            popUp.SetActive(true);
        }
    }

    public void NewDay()
    {
        paused = false;
        popUp.SetActive(false);
        weekdayDisplay.GetComponent<WeekdayManager>().dayNum++;
    }
}
