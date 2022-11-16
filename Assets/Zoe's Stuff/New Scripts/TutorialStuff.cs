using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStuff : MonoBehaviour
{
    [SerializeField]
    private GameObject instructions;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(TimeDelay());
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(3);

        instructions.SetActive(false);
        this.gameObject.SetActive(false);
    }
}
