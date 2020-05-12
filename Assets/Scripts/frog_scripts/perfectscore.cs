using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perfectscore : MonoBehaviour
{
    public bool goodlily;
    public bool perfectlily;
    public Animator lilyanim;

    public LevelController LC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // prevents the game from registering "good" and "perfect" at the same
    // time even though you are hitting both colliders
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.tag == "PH")
        {
            LC.goodscore = false;
            LC.perfectscore = true;
            lilyanim.SetBool("perfectlily", true);
        }
    }

    // prevents the score from registering "good" if you miss the pad
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "PH")
        {
            LC.goodscore = true;
            LC.perfectscore = false;
            lilyanim.SetBool("goodlily", true);
        }
    }

}
