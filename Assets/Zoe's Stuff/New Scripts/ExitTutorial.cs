using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTutorial : MonoBehaviour
{
    [SerializeField]
    private GameObject patronScript;

    [SerializeField]
    private GameObject popUp;

    // Update is called once per frame
    void Update()
    {
        if (patronScript.GetComponent<PatronScript>().patronsServed > 0)
        {
            popUp.SetActive(true);
        }
    }
}
