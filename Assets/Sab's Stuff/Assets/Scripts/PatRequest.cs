using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PatRequest : MonoBehaviour
{
    //these are placeholders for categories.
    public Text textDialogue;
    public string category1 = "Adventure";
    public string category2 = "Horror";
    public string category3 = "Fantasy";
    public string category4 = "Romance";

    public string category5 = "Adventure Horror";
    

    public string category6 = "Adventure Fantasy";
  

    public string category7 = "Adventure Romance";
   

    public string category8 = "Horror Fantasy";
   

    public string category10 = "Horror Romance";
    


    public string category13 = "Fantasy Romance";
  








    public bool served = false;

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
        
        chance = Random.Range(1, 161);
        if (chance >=1 && chance <= 10)
        {
            patronChild.gameObject.tag = category1;
            textDialogue.text = "Hi, I'd like a Green book please";
            Debug.Log(patronChild.gameObject.tag);

        } else if (chance >= 11 && chance <=20)
        {
            patronChild.gameObject.tag = category2;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Yellow book please";

        } else if (chance >= 21 && chance <= 30)
        {
            patronChild.gameObject.tag = category3;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Blue book please";
        }
        else if (chance >= 31 && chance <= 40)
        {
            patronChild.gameObject.tag = category4;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Red book please";
        }
        else if (chance >= 41 && chance <= 50)
        {
            patronChild.gameObject.tag = category5;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Green and Yellow  book please";
        }
        else if (chance >= 51 && chance <= 60)
        {
            patronChild.gameObject.tag = category6;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Green and Blue book please";
        }
        else if (chance >= 61 && chance <= 70)
        {
            patronChild.gameObject.tag = category7;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Green and Red book please";
        }
        else if (chance >= 71 && chance <= 80)
        {
            patronChild.gameObject.tag = category8;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Yellow and Green book please";
        }
        else if (chance >= 81 && chance <= 90)
        {
            patronChild.gameObject.tag = category5;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Yellow and Blue book please";
        }
        else if (chance >= 91 && chance <= 100)
        {
            patronChild.gameObject.tag = category10;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Yellow and Red book please";
        }
        else if (chance >= 101 && chance <= 110)
        {
            patronChild.gameObject.tag = category6;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Blue and Green book please";
        }
        else if (chance >= 111 && chance <= 120)
        {
            patronChild.gameObject.tag = category8;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Blue and Yellow book please";
        }
        else if (chance >= 121 && chance <= 130)
        {
            patronChild.gameObject.tag = category13;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Blue and Red book please";
        }
        else if (chance >= 131 && chance <= 140)
        {
            patronChild.gameObject.tag = category7;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Red and Green book please";
        }
        else if (chance >= 141 && chance <= 150)
        {
            patronChild.gameObject.tag = category10;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Red and Yellow book please";
        }
        else if (chance >= 151 && chance <= 160)
        {
            patronChild.gameObject.tag = category13;
            Debug.Log(patronChild.gameObject.tag);
            textDialogue.text = "Hi, I'd like a Red and Blue book please";
        }


    }

    public void PatronServed()
    {
        this.tag = "Served";
        served = true;
        this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + 10, this.gameObject.transform.position.y + 10);
        StartCoroutine(TestSpawnTimer());
        Debug.Log("Event Rec");

        //this is used to test if the Patron Script works.
        IEnumerator TestSpawnTimer()
        {
            yield return new WaitForSeconds(5f);
           
            //GameObject.Find("PatronSpawnPoint").GetComponent<BookPile>().AddBookToPile();
            //Destroy(this.gameObject);

        }
    }

}
