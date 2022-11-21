using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPatronScript : MonoBehaviour
{
    public GameObject patron;
    public GameObject patron1;
    public GameObject patron2;
    public GameObject patron3;
    public GameObject patron4;
    public GameObject patron5;
    public Transform spawnHere;
    string Patron = "Patron";
    public int patronsServed = 0;

    bool winStateSeen = false;

    public GameObject winState;
    public GameObject loseState;

    public int daysPassed;
    public int daysFailed;
    int patronType;

    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (daysFailed > 2)
        {
            loseState.SetActive(true);
        }

        if ((daysFailed + daysPassed) == 6)
        {
            winState.SetActive(true);
        }

        // this prevents the winstate from showing every day
        if (winStateSeen == false)
        {
            if (daysPassed < 4)
            {
                //player has been "hired" do something.
                winStateSeen = true;
            }
        }

    }

    private void FixedUpdate()
    {

        //This will check if there is a patron that already exists in the scene.
        if (GameObject.FindGameObjectWithTag("Patron") == null)
        {
            //no patron exists
            // Debug.Log("They don't exist");
            StartCoroutine(Interval());

        }
    }

    //if there is no patron in the scene a countdown will start.
    IEnumerator Interval()
    {
        yield return new WaitForSeconds(0.5f);
        if (GameObject.FindGameObjectWithTag("Clock").GetComponent<TutorialClockScript>().dayTime == true)
        {
            SpawnPatron();
        }

        StopAllCoroutines();
        //StopCoroutine(Interval());

    }


    //This will spawn a patron after the ccountdown is finished.
    public void SpawnPatron()
    {
        PatRequest[] patrons = FindObjectsOfType(typeof(PatRequest)) as PatRequest[];
        foreach (PatRequest pat in patrons)
        {
            Destroy(pat.gameObject);
        }
        patronType = Random.Range(1, 5);
        if (patronType == 1)
        {
            Instantiate(patron1, spawnHere);
        }
        else if (patronType == 2)
        {
            Instantiate(patron2, spawnHere);
        }
        else if (patronType == 3)
        {
            Instantiate(patron3, spawnHere);
        }
        else if (patronType == 4)
        {
            Instantiate(patron4, spawnHere);
        }

        // Instantiate(patron, spawnHere);
    }
}
