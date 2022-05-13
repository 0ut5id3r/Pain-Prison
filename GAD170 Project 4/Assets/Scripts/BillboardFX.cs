using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardFX : MonoBehaviour
{
    public Transform camTransform;

    Quaternion originalRotation;

    private void Awake()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            camTransform = GameObject.Find("PlayerCam").transform;
        }
    }

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (GameObject.FindWithTag("Player") != null)
        {
            transform.rotation = camTransform.rotation * originalRotation;
        }
    }
}