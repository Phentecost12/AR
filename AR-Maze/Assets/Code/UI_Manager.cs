using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance { get; private set; } = null;

    [SerializeField] private TextMeshProUGUI scoreTXT;
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject WinPanel;
    
    private void Awake()
    {
        infoPanel.SetActive(false);

        if (instance != null) 
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    public void Update_Score(int i) 
    {
        scoreTXT.text = "Coins: " + i;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void InfoAppaear()
    {
        infoPanel.SetActive(true);    }

    public void InfoDissapear()
    {
        infoPanel.SetActive(false);
        //Evaluar si se debe parar la exp
    }

    public void Win_Game() 
    {
        WinPanel.SetActive(true);
    }
}
