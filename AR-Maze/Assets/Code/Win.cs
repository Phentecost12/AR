using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UI_Manager.instance.Win_Game();
        Game_Manager.instance.player.SetActive(false);
    }
}
