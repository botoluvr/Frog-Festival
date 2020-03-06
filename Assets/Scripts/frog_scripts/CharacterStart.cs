using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CharacterStart : MonoBehaviour
{
    public Animator anim;
    public bool HasTurn;
    public SimpleController SC;
    public GameObject CVC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CVC.SetActive(true);
        }
    }

    public void CharacterBegin()
    {
        SC.enabled = true;
    }

    public void CharacterTurn()
    {
        if (HasTurn == false)
        {
            anim.SetBool("turn", true);
            HasTurn = true;
        }

        else if (HasTurn == true)
        {
            anim.SetBool("turn", false);
            HasTurn = false;
        }
    }
}
