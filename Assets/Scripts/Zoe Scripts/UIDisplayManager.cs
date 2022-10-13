using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplayManager : MonoBehaviour
{
    [SerializeField]
    private GameObject libraryUI;
    [SerializeField]
    private GameObject dungeonUI;

    private CanvasGroup library;
    private CanvasGroup dungeon;

    //fetches canvas groups
    private void Start()
    {
        library = libraryUI.GetComponent<CanvasGroup>();
        dungeon = dungeonUI.GetComponent<CanvasGroup>();
    }
    private void Update()
    {
        //makes the dungeon ui interactable and visiable and the library ui non interactable and invisible
        if (Input.GetKeyDown(KeyCode.Z))
        {
            library.blocksRaycasts = false;
            dungeon.blocksRaycasts = true;

            library.alpha = 0;
            dungeon.alpha = 1;
        }

        //makes the library ui interactable and visiable and the dungeon ui non interactable and invisible
        if (Input.GetKeyDown(KeyCode.X))
        {
            library.blocksRaycasts = true;
            dungeon.blocksRaycasts = false;

            library.alpha = 1;
            dungeon.alpha = 0;
        }
    }
}
