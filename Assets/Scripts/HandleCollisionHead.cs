using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCollisionHead : MonoBehaviour
{
    [SerializeField]
    GameObject glasses;
    [SerializeField]
    GameObject key;
    [SerializeField]
    GameObject button1;
    [SerializeField]
    GameObject button2;
    [SerializeField]
    GameObject cofre;
    [SerializeField]
    GameObject screwdriver;
    [SerializeField]
    RawImage sangre1;
    [SerializeField]
    RawImage sangre2;
    [SerializeField]
    RawImage sangre3;
    [SerializeField]
    Text text1;
    [SerializeField]
    Text text2;
    public static bool glassesOn = false;

    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
        // cofre.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        screwdriver.SetActive(false);
        sangre1.enabled = false;
        sangre2.enabled = false;
        sangre3.enabled = false;
        text1.enabled = false;
        text2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "glasses OBJ")
        {
            glasses.SetActive(false);
            key.SetActive(true);
            button1.SetActive(true);
            cofre.SetActive(true);
            glassesOn = true;  
            sangre1.enabled = true;
            sangre2.enabled = true;
            sangre3.enabled = true;
        }
    }
}
