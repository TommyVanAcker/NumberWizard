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

    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("implement you win screen");
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
        Debug.Log("implement you lose Screen");
    }
}
