using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject xd;
    private void OnTriggerEnter(Collider other)
    {
        xd.SetActive(true);
        Game_Manager.instance.CheckPoint_Reach();
    }
}
