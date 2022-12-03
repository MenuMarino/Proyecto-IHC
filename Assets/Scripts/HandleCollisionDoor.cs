using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollisionDoor : MonoBehaviour
{
    
    [SerializeField]
    GameObject door;
    [SerializeField]
    GameObject finalKey;
    [SerializeField]
    GameObject policia;
    public GameObject foco;
    public float openRot, closeRot, speed;
    public bool opening;
    private bool opened = false;

    void Update()
    {
        if (opened) 
        {
            Vector3 currentRot = door.transform.localEulerAngles;
            if (currentRot.y < openRot)
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }
        
        // Vector3 currentRot = door.transform.localEulerAngles;
        // if (opening)
        // {
        //     if (currentRot.y < openRot)
        //     {
        //         door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
        //     }
        // }
        // else
        // {
        //     if (currentRot.y > closeRot)
        //     {
        //         door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, closeRot, currentRot.z), speed * Time.deltaTime);
        //     }
        // }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "FinalKey")
        {
            // door.SetActive(false);
            finalKey.SetActive(false);
            foco.SetActive(true);
            opened = true;
            policia.SetActive(false);
            GetComponent<BoxCollider>().enabled = false;
            // Vector3 currentRot = door.transform.localEulerAngles;
            // door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
        }
    }
}
