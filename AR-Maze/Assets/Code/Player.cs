using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().maxLinearVelocity = 0.75f;
        GetComponent<Rigidbody>().maxAngularVelocity = 0.75f;
        Game_Manager.instance.Register(gameObject);
    }

    private void OnEnable()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        Game_Manager.instance.Reset_Player_Position();
    }

    private void OnDisable()
    {
        GetComponent <Rigidbody>().isKinematic = true;  
    }
}
