using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject heartField;
    
    private GameObject heartOne;
    private GameObject heartTwo;
    private GameObject heartThree;
    private GameObject heartFour;
    private GameObject heartFive;
    private GameObject heartSix;
    private GameObject heartSeven;
    private GameObject heartEight;

    private GameObject[] heartsArray = new GameObject[8];

    public int currantHealth = 5;
    public int maxHealth = 5;

    public bool firstUpgrade;
    public bool secondUpgrade;

    private void Start()
    {
        heartsArray[0] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform); 
        heartsArray[1] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        heartsArray[2] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        heartsArray[3] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        heartsArray[4] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        heartsArray[5] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        heartsArray[6] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        heartsArray[7] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7) && !firstUpgrade)
        {
            firstUpgrade = true;
            currantHealth++;
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) && !secondUpgrade)
        {
            secondUpgrade = true;
            currantHealth++;
        }

        if (firstUpgrade)
        {
            heartsArray[6].SetActive(true);
            maxHealth = 7;
        }
        else
        {
            heartsArray[6].SetActive(false);
        }

        if (firstUpgrade && secondUpgrade)
        {
            heartsArray[7].SetActive(true);
            maxHealth = 8;
        }
        else
        {
            heartsArray[7].SetActive(false);
        }

        if (currantHealth > 0)
        {
            for (int i = (currantHealth - 1); i >= 0; i--)
            {
                heartsArray[i].SetActive(true);
            }
        }

        if(currantHealth <= (maxHealth - 1))
        {
            for (int i = currantHealth; i <= (maxHealth - 1); i++)
            {
                heartsArray[i].SetActive(false);
            }
        }    
    }
}
