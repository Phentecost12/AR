using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer_MOve : MonoBehaviour
{
    Rigidbody rg;
    [SerializeField] float speed = 2; 
    void Start()
    {
        rg = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rg.velocity = input * speed;
    }
}
