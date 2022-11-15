using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutStuffTwo : MonoBehaviour
{
    [SerializeField]
    private GameObject bookcaseInstr;
    [SerializeField]
    private GameObject patronInstr;

    [SerializeField]
    private GameObject collider1;
    [SerializeField]
    private GameObject collider2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        patronInstr.SetActive(false);
        bookcaseInstr.SetActive(true);
        collider1.SetActive(false);
        collider2.SetActive(false);
    }
}
