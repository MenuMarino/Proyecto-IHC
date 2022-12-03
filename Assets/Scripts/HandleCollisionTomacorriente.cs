using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollisionTomacorriente : MonoBehaviour
{
    [SerializeField]
    GameObject finalKey;
    [SerializeField]
    GameObject tomacorriente;
    [SerializeField]
    GameObject screwdriver;
    public Animator tomacorrienteAnim;
    // Start is called before the first frame update
    void Start()
    {
        finalKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "screwdriver")
        {
            finalKey.SetActive(true);
            screwdriver.SetActive(false);
            tomacorrienteAnim.enabled = true;
        }
    }
}
