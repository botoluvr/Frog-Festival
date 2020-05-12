using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodscore : MonoBehaviour
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

    // sets a bool depending on the score (good/perfect)
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        if(collision.tag == "PH")
        {
            LC.goodscore = true;
        }
    }
    
    // prevents the score from registering "good" if you miss the pad
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "PH")
        {
            LC.goodscore = false;
        }
    }
}
