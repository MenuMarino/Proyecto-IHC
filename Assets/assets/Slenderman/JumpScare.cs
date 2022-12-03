using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject Susto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "OVRPlayerController")
        {
            Susto.SetActive(true);
        }
    }
}
