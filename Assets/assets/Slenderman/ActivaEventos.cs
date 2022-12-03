using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaEventos : MonoBehaviour
{
    public GameObject fantasmaObj;
    public Animator fantasma;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "OVRPlayerController")
        {
            fantasmaObj.SetActive(true);
            Destroy(gameObject);
        }
    }
}
