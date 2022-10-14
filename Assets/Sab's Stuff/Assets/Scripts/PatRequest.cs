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


    public int chance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(chance);
    }
    private void Awake()
    {
        chance = Random.Range(1,600);
        if(chance >1&& chance < 100)
        {
            patronChild.gameObject.tag = category1;

        } else if (chance > 101 && chance < 200)
        {
            patronChild.gameObject.tag = category2;

        } else if (chance > 201 && chance < 300)
        {
            patronChild.gameObject.tag = category3;
        }
        else if (chance > 301 && chance < 400)
        {
            patronChild.gameObject.tag = category4;
        }
        else if (chance > 401 && chance < 500)
        {
            patronChild.gameObject.tag = category5;
        }
        else if (chance > 501 && chance < 600)
        {
            patronChild.gameObject.tag = category6;
        }

    }
}
