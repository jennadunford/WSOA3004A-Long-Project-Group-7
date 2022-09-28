using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncrease : MonoBehaviour
{
    [SerializeField]
    private GameObject healthManager;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && healthManager.GetComponent<HealthManager>().currantHealth > 0)
        {
            healthManager.GetComponent<HealthManager>().currantHealth -= 1;
        }

        if (Input.GetKeyDown(KeyCode.H) && healthManager.GetComponent<HealthManager>().currantHealth < 6)
        {
            healthManager.GetComponent<HealthManager>().currantHealth += 1;
        }
    }
}
