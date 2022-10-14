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
        if (GameObject.FindGameObjectWithTag(Patron) == null)
        {
            //no patron exists
            Debug.Log("They don't exist");
            StartCoroutine(Interval());

        }
    }

    IEnumerator Interval()
    {
        yield return new WaitForSeconds(5f);
        SpawnPatron();
        StopAllCoroutines();
        
    }



    public void SpawnPatron()
    {
        Instantiate(patron, spawnHere);
    }
}
