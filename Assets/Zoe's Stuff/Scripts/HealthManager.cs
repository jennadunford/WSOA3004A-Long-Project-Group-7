using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;

    private GameObject[] heartsArray = new GameObject[8];

    private int currantHealth = 6;
    private int maxHealth = 6;

    public bool firstUpgrade;
    public bool secondUpgrade;
    
    //I apologise that this script is such a mess, I will clean it up some how for the alpha but I figured this is good enough for now
    private void Start()
    {
        //instantiates a heart prefab in every element of the array
        for (int i = 0; i < heartsArray.Length; i++)
        {
            heartsArray[i] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        }
    }

    void Update()
    {
        //decreases health
        if (Input.GetKeyDown(KeyCode.Space) && currantHealth > 0)
        {
            currantHealth -= 1;
        }

        //increases health
        if (Input.GetKeyDown(KeyCode.H) && currantHealth < maxHealth)
        {
            currantHealth += 1;
        }

        //unlocks first upgrade
        if (Input.GetKeyDown(KeyCode.Keypad7) && !firstUpgrade)
        {
            firstUpgrade = true;
            currantHealth++;
        }

        //unlocks second upgrade
        if (Input.GetKeyDown(KeyCode.Keypad8) && !secondUpgrade)
        {
            secondUpgrade = true;
            currantHealth++;
        }

        //increases total health to 7
        if (firstUpgrade)
        {
            heartsArray[6].SetActive(true);
            maxHealth = 7;
        }
        else
        {
            heartsArray[6].SetActive(false);
        }

        //increases total health to 8
        if (firstUpgrade && secondUpgrade)
        {
            heartsArray[7].SetActive(true);
            maxHealth = 8;
        }
        else
        {
            heartsArray[7].SetActive(false);
        }

        //increases the number of hearts shown
        if (currantHealth > 0)
        {
            for (int i = (currantHealth - 1); i >= 0; i--)
            {
                heartsArray[i].SetActive(true);
            }
        }

        //decreases the number of hearrts displayed
        if(currantHealth <= (maxHealth - 1))
        {
            for (int i = currantHealth; i <= (maxHealth - 1); i++)
            {
                heartsArray[i].SetActive(false);
            }
        }    
    }
}
