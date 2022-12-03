using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollision : MonoBehaviour
{
    [SerializeField]
    GameObject treasureBox;
    [SerializeField]
    GameObject key;
    [SerializeField]
    GameObject screwdriver;
    [SerializeField]
    GameObject button1;
    [SerializeField]
    GameObject button2;
    [SerializeField]
    GameObject policeCar;

    // Start is called before the first frame update
    void Start()
    {
        // screwdriver.SetActive(false);
        button2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Key")
        {
            treasureBox.SetActive(false);
            key.SetActive(false);
            button1.SetActive(false);
            screwdriver.SetActive(true);
            button2.SetActive(true);
            policeCar.SetActive(true);
        }
    }
}
