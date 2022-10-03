using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPickUp : MonoBehaviour
{
    public GameObject player;
    public GameObject weaponVisualiser;
    public GameObject weaponRangeVisualiser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.gameObject.GetComponent<PlayerController>().weaponEqipped = true;
        weaponVisualiser.SetActive(true);
        weaponRangeVisualiser.SetActive(true);

        Destroy(this.gameObject);
    }
}
