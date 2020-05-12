using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpointVisual : MonoBehaviour
{
    //vv calls the checkpoint animator vv
    public bool Bloom;
    public Animator anim;

    public Image CheckpointUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            CheckpointUI.enabled = true;
            anim.SetBool("Bloom", true);
        }
    }
    
}
