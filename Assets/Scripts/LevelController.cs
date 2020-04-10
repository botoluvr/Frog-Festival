using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public bool respawning;
    public float waitToRespawn;
    public SimpleController sc;
    public SpriteRenderer sr;
    public Rigidbody2D rb2D;
    public Animator myanim;
    public CharacterStart cs;
    public AudioSource currentsong;
    public AudioSource song1;
    public AudioSource song2;
    public AudioSource song3;
    public AudioSource song4;

    public AudioSource goodhitsound;
    public AudioSource perfecthitsound;

    // bool for outputing and effect depending on the schore
    public bool goodscore;
    public bool perfectscore;
    public Text good;
    public Text perfect;


    // Start is called before the first frame update
   private void Start()
    {
        currentsong = song1;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void Respawn()
    {
        // variables that will allow us to limit number of respawns
        respawning = true;
        StartCoroutine("RespawnCo");
    }

    public IEnumerator RespawnCo()
    {
        sc.enabled = false;
        sc.turn = false;
        myanim.SetBool("turn", false);
        cs.HasTurn = false;
        cs.alive = false;
        sr.enabled = false;
        rb2D.simulated = false;
        currentsong.Stop();

        yield return new WaitForSeconds(waitToRespawn);

        cs.alive = true;
        respawning = false;
        sc.transform.position = sc.respawnPosition;
        sc.enabled = true;
        sr.enabled = true;
        rb2D.simulated = true;
        currentsong.Play();

    }

    public void LilyHit()
    {
        if(goodscore == true)
        {
            StartCoroutine(Goodhit());
            //goodhitsound.Play();
        }

        if (perfectscore == true)
        {
            StartCoroutine(Perfecthit());
            //perfecthitsound.Play();
        }
    }

    IEnumerator GoodHit()
    {
        good.enabled = true;
        yield return new WaitForSeconds(.25f);
        good.enabled = false;
    }

    IEnumerator GPerfectHit()
    {
        perfect.enabled = true;
        yield return new WaitForSeconds(.25f);
        perfect.enabled = false;
    }
}
