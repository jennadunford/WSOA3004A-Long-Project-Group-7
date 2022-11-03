using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Windowed : MonoBehaviour
{
    public void OnChange()
    {
        if (GetComponent<Toggle>().isOn)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }

        if(!GetComponent<Toggle>().isOn)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
    }
}
