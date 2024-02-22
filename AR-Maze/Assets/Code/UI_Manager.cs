using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance { get; private set; } = null;

    [SerializeField] private TextMeshProUGUI scoreTXT;

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
}
