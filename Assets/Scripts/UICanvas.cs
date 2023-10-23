using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvas : MonoBehaviour
{
    public GameObject Pause_UI;

    public void PauseBtn()
    {
        Pause_UI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeBtn()
    {
        Pause_UI.SetActive(false);
        Time.timeScale = 1f;
    }

}
