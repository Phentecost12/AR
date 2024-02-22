using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit_Colliders : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Game_Manager.instance.Reset_Player_Position();
    }
}
