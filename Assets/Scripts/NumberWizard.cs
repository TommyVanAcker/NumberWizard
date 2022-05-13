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

    int speelGetal;

    // Start is called before the first frame update
    void Start()
    {
        speelGetal = Random.Range(minGetal, maxGetal + 1);
        raadGetal.text = speelGetal.ToString();
    }

    void RaadVolgende()
    {
        speelGetal = Random.Range(minGetal, maxGetal + 1);
        raadGetal.text = speelGetal.ToString();
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
}
