using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    //below variables allow the bought items to change the player
    public PlayerController pc;
    public int pinkFrog; //aka PFrog
    public GameObject inventoryPFrog; //button in inventory (roster?)
    public bool changePFrog; //bool tells us if we are wearing frog skin 
    public GameObject pinkFrogSkin; //the actual sprite change (the physical object like the party hat ont the birds head from robs example)

    //this keeps track of the player's gold
    public int goldCount;
    public Text goldText;

    //this makes the items in the shop buttons so when u click on them it does something
    public Button shopPFrog;
    public Button rosterPink;

    //if we own something we dont want to purchase it again
    public bool ownPFrog;

    // Start is called before the first frame update
    void Start()
    {
        goldCount = PlayerPrefs.GetInt("Gold"); //for saving gold between sessions
        pinkFrog = PlayerPrefs.GetInt("pinkFrog");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Gold", goldCount); //for saving gold between sessions

        goldText.text = "" + goldCount;

        if (pinkFrog == 1 && rosterPink != null)
        {
            rosterPink.interactable = true;
        }

        else if (pinkFrog == 0 && rosterPink != null)
        {
            rosterPink.interactable = false;
        }

        if (goldCount >= 5 && ownPFrog == false) //if we have enough gold and didnt but the skin yet
        {
            if (shopPFrog != null)
            {
                shopPFrog.interactable = true; //button is now clickable
            }

        }

        else 
        {
            if (shopPFrog != null)
            {
                shopPFrog.interactable = false;
            }

        }


    }

    public void BuyPFrog()
    {
        goldCount -= 5;
        PlayerPrefs.SetInt("pinkFrog", 1);
        shopPFrog.interactable = false;
        ownPFrog = true;
    }

    public void WearPFrog()
    {
        //PlayerPrefs.SetInt("FrogSkin", 1);
        //changePFrog = true;
    }

    public void reset()
    {
        PlayerPrefs.SetInt("pinkFrog", 0);
        PlayerPrefs.SetInt("Gold", 0);
        PlayerPrefs.SetInt("frogskin", 0);
        //inventoryPFrog.SetActive(false);
        goldCount = PlayerPrefs.GetInt("Gold");
        goldText.text = "" + goldCount;
        //changePFrog = false;
    }
}
