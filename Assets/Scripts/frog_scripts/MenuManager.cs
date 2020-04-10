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

    //if we own something we dont want to purchase it again
    public bool ownPFrog;

    // Start is called before the first frame update
    void Start()
    {
        goldCount = PlayerPrefs.GetInt("Gold"); //for saving gold between sessions
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Gold", goldCount); //for saving gold between sessions

        goldText.text = "Gold:" + goldCount;
        pinkFrog = PlayerPrefs.GetInt("pinkFrogSkin");

        if (pinkFrog == 1)
        {
            inventoryPFrog.SetActive(true); //turns on the skins button in our inventory/roster
        }

        if (changePFrog == true)
        {
            pinkFrogSkin.SetActive(true); //lets us see skin on frog
        }

        if (changePFrog == false)
        {
            pinkFrogSkin.SetActive(false); //hides skin again
        }

        if (goldCount >= 5 && ownPFrog == false); //if we have enough gold and didnt buy the hat yet
        {
            shopPFrog.interactable = true; //the frog button is now clickable in the shop
        }
    }
}
