using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookReturnScript : MonoBehaviour
{
    public int bookdelay;
    public Transform bookpile;
    public GameObject book;
    // Start is called before the first frame update
    void Start()
    {
        // this is the amount of time the book will be out of the library for (between 20 and 60 seconds).
        bookdelay = Random.Range(20, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This Coroutine will be started when the patron gets the book.
    IEnumerator BookReturnTime()
    {
        yield return new WaitForSeconds(bookdelay);
        BookGoesToPile();
           
    }

    void BookGoesToPile()
    {
        Instantiate(book, bookpile);
        //Book gets put into the pile
    }

}
