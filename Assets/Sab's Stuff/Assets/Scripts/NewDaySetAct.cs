using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDaySetAct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeActive()
    {
        Debug.Log("1");

        GameObject ghild =  null;

        if (transform.childCount != 0)
        {
            ghild = this.transform.GetComponentInChildren<Return>(true).gameObject;
        }

        Debug.Log("2");

        if (ghild != null)
        {
            Debug.Log(ghild);
            ghild.SetActive(true);

            
        }
       // Debug.Log("")
    }

    private void OnEnable()
    {
        ClockController.OnDayChanged += MakeActive;
    }

    private void OnDisable()
    {
        ClockController.OnDayChanged -= MakeActive;
    }
}
