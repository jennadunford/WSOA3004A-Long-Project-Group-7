using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTrolley : MonoBehaviour
{
    [SerializeField]
    private GameObject trolley;

    private void Update()
    {
        this.gameObject.transform.position = new Vector3(trolley.transform.position.x, trolley.transform.position.y + 0.15f, trolley.transform.position.z);
    }
}
