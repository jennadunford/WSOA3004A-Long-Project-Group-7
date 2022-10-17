using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatRequest : MonoBehaviour
{
    //these are placeholders for categories.

    public string category1 = "cat1";
    public string category2 = "cat2";
    public string category3 = "cat3";
    public string category4 = "cat4";
    public string category5 = "cat5";
    public string category6 = "cat6";

    //this will be the game object that the tag gets assigned on. 
    public GameObject patronChild;


    public int chance=0;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
      // Debug.Log(patronChild.gameObject.tag);
    }

    //this code will generate a number between 1 and 600, this will give a chance of differnt patrons requesting differnt book categories. It will then assign that category to a child of the patron.
    //that will be used to check if the book the player puts on the patron is correct or not.
    private void Awake()
    {
        chance = Random.Range(1, 601);
        if (chance >1&& chance < 100)
        {
            patronChild.gameObject.tag = category1;
            Debug.Log(patronChild.gameObject.tag);

        } else if (chance > 101 && chance < 200)
        {
            patronChild.gameObject.tag = category2;
            Debug.Log(patronChild.gameObject.tag);

        } else if (chance > 201 && chance < 300)
        {
            patronChild.gameObject.tag = category3;
            Debug.Log(patronChild.gameObject.tag);
        }
        else if (chance > 301 && chance < 400)
        {
            patronChild.gameObject.tag = category4;
            Debug.Log(patronChild.gameObject.tag);
        }
        else if (chance > 401 && chance < 500)
        {
            patronChild.gameObject.tag = category5;
            Debug.Log(patronChild.gameObject.tag);
        }
        else if (chance > 501 && chance < 600)
        {
            patronChild.gameObject.tag = category6;
            Debug.Log(patronChild.gameObject.tag);
        }

    }
}
