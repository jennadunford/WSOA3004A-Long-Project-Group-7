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
        chance = Random.Range(1, 41);
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
