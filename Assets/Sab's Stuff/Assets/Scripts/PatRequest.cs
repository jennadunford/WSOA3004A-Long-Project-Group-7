using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatRequest : MonoBehaviour
{
    //these are placeholders for categories.

    public string category1 = "Adventure";
    public string category2 = "Horror";
    public string category3 = "Fantasy";
    public string category4 = "Romance";


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
        chance = Random.Range(1, 40);
        if (chance >1&& chance < 10)
        {
            patronChild.gameObject.tag = category1;
            Debug.Log(patronChild.gameObject.tag);

        } else if (chance > 10 && chance < 20)
        {
            patronChild.gameObject.tag = category2;
            Debug.Log(patronChild.gameObject.tag);

        } else if (chance > 21 && chance < 30)
        {
            patronChild.gameObject.tag = category3;
            Debug.Log(patronChild.gameObject.tag);
        }
        else if (chance > 31 && chance < 40)
        {
            patronChild.gameObject.tag = category4;
            Debug.Log(patronChild.gameObject.tag);
        }


    }

    public void PatronServed()
    {
        this.tag = "Served";
        this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + 100, this.gameObject.transform.position.y + 100);
        StartCoroutine(TestSpawnTimer());
        

        //this is used to test if the Patron Script works.
        IEnumerator TestSpawnTimer()
        {
            yield return new WaitForSeconds(5f);
            GameObject.Find("PatronSpawnPoint").GetComponent<BookPile>().AddBookToPile();
            Destroy(this.gameObject);

        }
    }

}
