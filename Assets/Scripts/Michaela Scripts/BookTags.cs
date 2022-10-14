using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookTags : MonoBehaviour
{
    GameObject Romance;
    GameObject Children;
    GameObject Fantasy;
    GameObject Adventure;
    GameObject Mystery;
    GameObject Horror;

    GameObject RomanceAndChildren;
    GameObject RomanceAndFantasy;
    GameObject RomanceAndAdventure;
    GameObject RomanceAndMystery;
    GameObject RomanceAndHorror;
    GameObject ChildrenAndFantasy;
    GameObject ChildrenAndAdventure;
    GameObject ChildrenAndMystery;
    GameObject ChildrenAndHorror;
    GameObject FantasyAndAdventure;
    GameObject FantasyAndMystery;
    GameObject FantasyAndHorror;
    GameObject AdventureAndMystery;
    GameObject AdventureAndHorror;
    GameObject MysteryAndHorror;

    void Start()
    {
        Romance = GameObject.FindGameObjectWithTag("Romance");
        Children = GameObject.FindGameObjectWithTag("Children");
        Fantasy = GameObject.FindGameObjectWithTag("Fantasy");
        Adventure = GameObject.FindGameObjectWithTag("Adventure");
        Mystery = GameObject.FindGameObjectWithTag("Mystery");
        Horror = GameObject.FindGameObjectWithTag("Horror");

        RomanceAndChildren = GameObject.FindGameObjectWithTag("RomanceAndChildren");
        RomanceAndFantasy = GameObject.FindGameObjectWithTag("RomanceAndFantasy");
        RomanceAndAdventure = GameObject.FindGameObjectWithTag("RomanceAndAdventure");
        RomanceAndMystery = GameObject.FindGameObjectWithTag("RomanceAndMystery");
        RomanceAndHorror = GameObject.FindGameObjectWithTag("RomanceAndHorror");
        ChildrenAndFantasy = GameObject.FindGameObjectWithTag("ChildrenAndFantasy");
        ChildrenAndAdventure = GameObject.FindGameObjectWithTag("ChildrenAndAdventure");
        ChildrenAndMystery = GameObject.FindGameObjectWithTag("ChildrenAndMystery");
        ChildrenAndHorror = GameObject.FindGameObjectWithTag("ChildrenAndHorror");
        FantasyAndAdventure = GameObject.FindGameObjectWithTag("FantasyAndAdventure");
        FantasyAndMystery = GameObject.FindGameObjectWithTag("FantasyAndMystery");
        FantasyAndHorror = GameObject.FindGameObjectWithTag("FantasyAndHorror");
        AdventureAndMystery = GameObject.FindGameObjectWithTag("AdventureAndMystery");
        AdventureAndHorror = GameObject.FindGameObjectWithTag("AdventureAndHorror");
        MysteryAndHorror = GameObject.FindGameObjectWithTag("MysteryAndHorror");
    }
}
