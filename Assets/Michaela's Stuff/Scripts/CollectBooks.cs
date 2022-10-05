using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBooks : MonoBehaviour
{
    public GameObject book;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        book.SetActive(false);
        enemy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy == false)
        {
            book.SetActive(true);
            Debug.Log("Book is active. Enemy is dead.");
        }
    }

    //void OnTriggerEnter(Collision col)
    //{
    //    if (col.gameObject == book)
    //    {
    //        book.SetActive(false);
    //        Debug.Log("Collision with book");
    //    }
    //}
}
