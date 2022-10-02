using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellsManager : MonoBehaviour
{
    private bool[] spellsUsedArray = new bool[5];
    private GameObject[] spellBooksArray = new GameObject[5];

    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject spellsField;
    [SerializeField]
    private Sprite closedBook;
    [SerializeField]
    private Sprite openBook;

    [SerializeField]
    private int spellsLeft = 5;


    //I haven't yet coded additional spell slots for the player to unlock but I deff will for the alpha
    void Start()
    {
        //sets all the values in the array to false
        for (int i = 0; i < spellsUsedArray.Length; i++)
        {
            spellsUsedArray[i] = false;
        }

        //instantiates a spell book prefab in every element of the array
        for (int i = 0; i < spellBooksArray.Length; i++)
        {
            spellBooksArray[i] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, spellsField.transform);
        }
    }

    void Update()
    {
        //decreases the number of spells
        if (Input.GetKeyDown(KeyCode.S) && spellsLeft > 0)
        {
            spellsUsedArray[spellsLeft -1] = true;
            spellsLeft--;
        }

        //increase the number of spells
        if (Input.GetKeyDown(KeyCode.W) && spellsLeft < 5 && spellsLeft >= 0)
        {
            spellsUsedArray[spellsLeft] = false;
            spellsLeft++;
        }

        //changes ui to open book
        for (int i = (spellsLeft -1); i >= 0; i--)
        {
            spellsUsedArray[i] = false;
            spellBooksArray[i].GetComponent<Image>().sprite = openBook;
        }

        //changes the ui to closed book
        for (int i = spellsLeft; i <= 4; i++)
        {
            spellsUsedArray[i] = true;
            spellBooksArray[i].GetComponent<Image>().sprite = closedBook;
        }
        
    }
}
