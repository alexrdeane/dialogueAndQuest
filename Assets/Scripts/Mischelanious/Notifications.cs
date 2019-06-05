using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notifications : MonoBehaviour
{
    public Canvas myCanvas;

    void Start()
    {
        myCanvas = transform.Find("Canvas").GetComponent<Canvas>();
    }

    void Update()
    {
        myCanvas.transform.LookAt(Camera.main.transform);
    }
}