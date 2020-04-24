using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class songselect : MonoBehaviour
{
    public Animator Levels;
    public bool leftRight;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelTwo()
    {
        if (leftRight == false)
        {
            Levels.SetBool("LeftRight", true);
            leftRight = true;
        }

       else if (leftRight == true)
        {
            Levels.SetBool("LeftRight", false);
            leftRight = false;
        }
    }
}
