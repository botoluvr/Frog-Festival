using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleController : MonoBehaviour
{
    public bool turn;
    public Rigidbody2D myRigidBody;
    public float moveSpeed;

    public LevelController LC;
    public Vector3 respawnPosition;
    public CharacterStart cs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (turn == true)
        {
            myRigidBody.velocity = new Vector2(0, moveSpeed);
        }

        if (turn == false)
        {
            myRigidBody.velocity = new Vector2(-moveSpeed, 0);
        }
    }

    public void turnbird()
    {
        if (cs.alive == true)
        {
            if (turn == true)
            {
                turn = false;
            }
            else if (turn == false)
            {
                turn = true;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // tells the game to play the section of the song associated with each checkpoint
        if (collision.tag == "Checkpoint1")
        {
            respawnPosition = collision.transform.position;
            LC.currentsong.Stop();
            LC.currentsong = LC.song2;
            LC.currentsong.Play();
        }

        if (collision.tag == "Checkpoint2")
        {
            respawnPosition = collision.transform.position;
            LC.currentsong.Stop();
            LC.currentsong = LC.song3;
            LC.currentsong.Play();
        }

        if (collision.tag == "Checkpoint3")
        {
            respawnPosition = collision.transform.position;
            LC.currentsong.Stop();
            LC.currentsong = LC.song4;
            LC.currentsong.Play();
        }

        // sets the respawn reaction for hitting a wall
        if (collision.tag == "KillPlane")
        {
            //gameObject.SetActive (false);
            //transform.position = respawnPosition;
            if (LC.respawning == false)
            {
                LC.Respawn();
            }

        }

    }

}
