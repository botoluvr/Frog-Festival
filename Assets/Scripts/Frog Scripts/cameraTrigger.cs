using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraTrigger : MonoBehaviour
{
    public GameObject cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cam.SetActive(true);
    }
}