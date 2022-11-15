using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStuff : MonoBehaviour
{
    [SerializeField]
    private GameObject wasdInstr;
    [SerializeField]
    private GameObject patronInstr;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        patronInstr.SetActive(true);
        wasdInstr.SetActive(false);
    }
}
