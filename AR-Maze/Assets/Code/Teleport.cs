using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject super;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(super);
    }
}
