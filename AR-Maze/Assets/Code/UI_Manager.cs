using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance { get; private set; } = null;

    [SerializeField] private TextMeshProUGUI scoreTXT;
    [SerializeField] private Button exitButton;

    private void Awake()
    {
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
}
