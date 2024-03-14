using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Game_Manager.instance.Increase_Score();
        gameObject.SetActive(false);
    }
}
