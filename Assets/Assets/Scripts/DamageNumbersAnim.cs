using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNumbersAnim : MonoBehaviour
{

    void DestoryTextParent()
    {

        GameObject parent = gameObject.transform.parent.gameObject;
        Destroy(parent);
    }
}
