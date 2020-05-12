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

    //public AudioSource goodhitsound;
    //public AudioSource perfecthitsound;

    public bool goodlily;
    public bool perfectlily;
    public Animator lilyanim;

    // bool for outputing and effect depending on the schore
    public bool goodscore;
    public bool perfectscore;
    public Image GoodText;
    public Image PerfectText;

    //public Text Tutorial;
    //public Text Tutorial2;
    public int ComboScore;
    public Text CurrentComboScore;

    // Start is called before the first frame update
    private void Start()
    {
        currentsong = song1;
    }

    // Update is called once per frame
    private void Update()
    {
        //print current combo
        CurrentComboScore.text = ComboScore + "Combo";
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
        sc.turn = true;
        myanim.SetBool("turn", false);
        lilyanim.SetBool("goodlily", false);
        lilyanim.SetBool("perfectlily", false);
        cs.HasTurn = false;
        cs.alive = false;
        //GET RID OF THE LINE BELOW before enabling the death animation bool
        sr.enabled = false;
        //my anim.SetBool("death", true)
        rb2D.simulated = false;
        currentsong.Stop();

        yield return new WaitForSeconds(waitToRespawn);

        //my anim.SetBool("death", false)
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
        if (goodscore == false)
        {
            ComboScore = 0;
        }

        if(goodscore == true)
        {
            //combo sets back to 0
            GoodText.enabled = false;
            StartCoroutine(GoodHit());
            ComboScore = 0;
            //goodhitsound.Play();
        }

        if (perfectscore == true)
        {
            //combo counts up by one
            PerfectText.enabled = false;
            StartCoroutine(PerfectHit());
            ComboScore += 1;
            //perfecthitsound.Play();
        }
    }

    IEnumerator GoodHit()
    {
        GoodText.enabled = true;
        yield return new WaitForSeconds(.25f);
        GoodText.enabled = false;
    }

    IEnumerator PerfectHit()
    {
        PerfectText.enabled = true;
        yield return new WaitForSeconds(.25f);
        PerfectText.enabled = false;
    }
}
