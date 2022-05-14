using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
   public void LaadWinScreen()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public void LaadLoseScreen()
    {
        SceneManager.LoadScene("LooseScreen");
    }

    public void LaadSpeelScreen()
    {
        SceneManager.LoadScene("PlayScreen");
    }
}
