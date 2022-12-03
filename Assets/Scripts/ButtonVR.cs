using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;        
    }

    private void OnTriggerEnter(Collider other) {
        if (!isPressed) {
            button.transform.localPosition = new Vector3(2.75f, -2f, 2.82f);
            presser = other.gameObject;
            if (button.name == "Final Press") SceneManager.LoadScene("Final Scene");
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == presser) {
            button.transform.localPosition = new Vector3(2.75f, -1.84f, 2.82f);
            onRelease.Invoke();
            isPressed = false;
        }
    }
}
