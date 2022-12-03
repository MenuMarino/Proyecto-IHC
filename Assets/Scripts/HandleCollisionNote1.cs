using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCollisionNote1 : MonoBehaviour
{
    [SerializeField]
    private Text text;
    void Start()
    {
        text.enabled = false;    
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key")
        {
            text.enabled = true;  
        }
    }

    void OnCollisionExit(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Key")
        {
            text.enabled = false;    
        }
    }
}
