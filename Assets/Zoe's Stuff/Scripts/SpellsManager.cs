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

    public int spellsLeft = 5;

    void Start()
    {
        spellsUsedArray[0] = false;
        spellsUsedArray[1] = false;
        spellsUsedArray[2] = false;
        spellsUsedArray[3] = false;
        spellsUsedArray[4] = false;

        spellBooksArray[0] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, spellsField.transform);
        spellBooksArray[1] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, spellsField.transform);
        spellBooksArray[2] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, spellsField.transform);
        spellBooksArray[3] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, spellsField.transform);
        spellBooksArray[4] = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, spellsField.transform);
    }

    void Update()
    {
        Debug.Log(spellsLeft);

        if (Input.GetKeyDown(KeyCode.S) && spellsLeft > 0)
        {
            spellsUsedArray[spellsLeft -1] = true;
            spellsLeft--;
        }

        if (Input.GetKeyDown(KeyCode.W) && spellsLeft < 5)
        {
            spellsUsedArray[spellsLeft - 1] = false;
            spellsLeft++;
        }

        for (int i = (spellsLeft -1); i >= 0; i--)
        {
            spellsUsedArray[i] = false;
            spellBooksArray[i].GetComponent<Image>().sprite = openBook;
        }

        for (int i = (spellsLeft); i <= 4; i++)
        {
            spellsUsedArray[i] = true;
            spellBooksArray[i].GetComponent<Image>().sprite = closedBook;
        }
        
    }
}
