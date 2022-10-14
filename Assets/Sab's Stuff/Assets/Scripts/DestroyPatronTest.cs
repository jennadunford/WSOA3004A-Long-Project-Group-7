using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPatronTest : MonoBehaviour
{
    //this script is used to test if the check for the patron existing works. 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        StartCoroutine(TestSpawnTimer());
    }

    IEnumerator TestSpawnTimer()
    {
        yield return new WaitForSeconds(10f);
        Destroy(this.gameObject);
    }

    //If the player places the correct book in this inventory then this patron will be destroyed. 

    //if(the books tag == the book tag that the patron wanted)
    //{
    // patron gets destroyed with the book.
    // the players sucess metre for the day increases.
    // the books tag gets added to memory so we can bring back the book after a certain amount of time.
    // call a function in another script that will start a countdown for how long it will be untill the book is returned to the library.
    // 
    //}


}
