using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private GameObject heartOne;
    [SerializeField]
    private GameObject heartTwo;
    [SerializeField]
    private GameObject heartThree;
    [SerializeField]
    private GameObject heartFour;
    [SerializeField]
    private GameObject heartFive;
    [SerializeField]
    private GameObject heartSix;

    private GameObject[] heartsArray = new GameObject[6];

    public int currantHealth = 6;

    private void Start()
    {
        heartsArray[0] = heartOne;
        heartsArray[1] = heartTwo;
        heartsArray[2] = heartThree;
        heartsArray[3] = heartFour;
        heartsArray[4] = heartFive;
        heartsArray[5] = heartSix;
    }

    void Update()
    {
        if (currantHealth > 0)
        {
            heartsArray[currantHealth - 1].SetActive(true);

            for (int i = (currantHealth - 1); i >= 0; i--)
            {
                heartsArray[i].SetActive(true);
            }
        }

        if(currantHealth <= 5)
        {
            heartsArray[currantHealth].SetActive(false);

            for (int i = currantHealth; i <= (heartsArray.Length - 1); i++)
            {
                heartsArray[i].SetActive(false);
            }
        }
    }
}
