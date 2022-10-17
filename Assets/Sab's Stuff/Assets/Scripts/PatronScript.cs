using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatronScript : MonoBehaviour
{
    public GameObject patron;
    public Transform spawnHere;
    string Patron= "Patron";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        //This will check if there is a patron that already exists in the scene.
        if (GameObject.FindGameObjectWithTag(Patron) == null)
        {
            //no patron exists
           // Debug.Log("They don't exist");
            StartCoroutine(Interval());

        }
    }

        //if there is no patron in the scene a countdown will start.
    IEnumerator Interval()
    {
        yield return new WaitForSeconds(3f);
        SpawnPatron();
        StopAllCoroutines();
        
    }


        //This will spawn a patron after the ccountdown is finished.
    public void SpawnPatron()
    {
        Instantiate(patron, spawnHere);
    }
}
