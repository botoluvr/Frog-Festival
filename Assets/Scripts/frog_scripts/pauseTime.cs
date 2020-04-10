using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseTime : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseTimee()
    {
        Time.timeScale = 0;
    }

    public void unpauseTime()
    {
        Time.timeScale = 1;
    }
}
