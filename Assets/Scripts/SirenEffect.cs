using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenEffect : MonoBehaviour
{
    [SerializeField]
    Light red;
    [SerializeField]
    Light blue;

    private Vector3 redTemp;
    private Vector3 blueTemp;
    [SerializeField] int speed;

    void Update()
    {
        redTemp.y += speed * Time.deltaTime;
        blueTemp.y -= speed * Time.deltaTime;
        red.transform.eulerAngles = redTemp;
        blue.transform.eulerAngles = blueTemp;
    }
}
