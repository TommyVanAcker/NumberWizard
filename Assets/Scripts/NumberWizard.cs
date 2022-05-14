using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI raadGetal;
    [SerializeField] int minGetal = 1;
    [SerializeField] int maxGetal = 1000;
    [SerializeField] int raadPogingen = 4;

    int speelGetal;

    //cached references
    SceneHandler sceneHandler;

    // Start is called before the first frame update
    void Start()
    {
        sceneHandler = FindObjectOfType<SceneHandler>();
        speelGetal = Random.Range(minGetal, maxGetal + 1);
        raadGetal.text = speelGetal.ToString();
        raadPogingen--;
        CheckWinCondition();
       
    }

    void RaadVolgende()
    {
        speelGetal = Random.Range(minGetal, maxGetal + 1);
        raadGetal.text = speelGetal.ToString();
        raadPogingen--;
        CheckWinCondition();
    }

    void CheckWinCondition()
    {
        if(raadPogingen == 0)
        {
            sceneHandler.LaadWinScreen();
        }
    }

   public void RaadHoger()
    {
        minGetal = speelGetal;
        RaadVolgende();
    }


    public void RaadLager()
    {
        maxGetal = speelGetal;
        RaadVolgende();
    }

    public void CorrectGeraden()
    {
        sceneHandler.LaadLoseScreen();
    }
}
