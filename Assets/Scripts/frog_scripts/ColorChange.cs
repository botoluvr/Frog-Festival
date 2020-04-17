using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public int skin;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skin = PlayerPrefs.GetInt("SkinColor");
        if (skin == 0) 
        {
            sr.color = new Color(255, 255, 255, 1);
        }

        if (skin == 1)
        {
            sr.color = new Color(255, 0, 255, 1);
        }
    }

    public void WearPink()
    {
        PlayerPrefs.SetInt("SkinColor", 1);
    }

    public void WearGreen()
    {
        PlayerPrefs.SetInt("SkinColor", 0);
    }
}
