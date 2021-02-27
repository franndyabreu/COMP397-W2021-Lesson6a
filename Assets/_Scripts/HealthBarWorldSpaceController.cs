using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamera;

    void Start() {
        playerCamera = GameObject.Find("PlayerCamera").transform;
    }

    void LateUpdate()
    {
        // Billboard the healthbar
        transform.LookAt(transform.position + playerCamera.forward);
    }
}
