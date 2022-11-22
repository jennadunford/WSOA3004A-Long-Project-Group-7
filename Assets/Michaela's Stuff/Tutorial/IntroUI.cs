using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroUI : MonoBehaviour
{
    [SerializeField]
    private GameObject text1;
    [SerializeField]
    private GameObject text2;
    [SerializeField]
    private GameObject text3;

    [SerializeField]
    private GameObject glowClock;
    [SerializeField]
    private GameObject glowBookmark;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tutorial());
    }

    
    private IEnumerator Tutorial()
    {
        text1.SetActive(true);

        yield return new WaitForSeconds(4);

        text1.SetActive(false);
        text2.SetActive(true);
        glowClock.SetActive(true);

        yield return new WaitForSeconds(10);

        text2.SetActive(false);
        glowClock.SetActive(false);
        text3.SetActive(true);
        glowBookmark.SetActive(true);

        yield return new WaitForSeconds(10);

        text3.SetActive(false);
        glowBookmark.SetActive(false);
    }
}
