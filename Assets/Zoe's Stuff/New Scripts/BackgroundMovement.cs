using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject clock;

    public float startOfDay = -46;

    private float speed;
    public float timePassed;
    public float modifier;


    void Update()
    {
        speed = 92 / clock.GetComponent<ClockController>().duration;
        timePassed += Time.deltaTime;
        modifier = -timePassed * -speed;

        transform.position = new Vector3(startOfDay + modifier, 0, 0);

        if (timePassed > clock.GetComponent<ClockController>().duration)
        {
            timePassed = 0;
        }
    }
}
