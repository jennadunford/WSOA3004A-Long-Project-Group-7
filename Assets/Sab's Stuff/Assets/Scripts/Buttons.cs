using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    GameObject slot;
    // Start is called before the first frame update
    void Start()
    {
        slot = GameObject.FindGameObjectWithTag("Slo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rem()
    {

        this.transform.parent.GetComponent<RemoveFromPile>().isUsed = false;
        Destroy(this.gameObject);
    }
}
