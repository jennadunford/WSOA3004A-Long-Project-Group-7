using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBooksScript : MonoBehaviour
{

    private GameObject bookSlot;
    private bool moving;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;


    void Start()
    {
        resetPosition = this.transform.localPosition;

        bookSlot = GameObject.FindGameObjectWithTag("BookSlot");

    }

    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(this.transform.localPosition.x - bookSlot.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.y - bookSlot.transform.localPosition.y) <= 0.5f)
        {
            this.transform.position = new Vector3(bookSlot.transform.position.x, bookSlot.transform.position.y, bookSlot.transform.position.z);
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
