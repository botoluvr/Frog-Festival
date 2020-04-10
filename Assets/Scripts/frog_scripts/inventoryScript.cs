using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryScript : MonoBehaviour
{

    //pieces of script pulled from the menumanager script specifically for the inventory scene since ours is separate from the shop, idk if any of this is right rib just said to pull these lines

    public int pinkFrog;
    public GameObject inventoryPFrog; //button in inventory (roster?)
    public bool changePFrog; //bool tells us if we are wearing frog skin 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pinkFrog = PlayerPrefs.GetInt("pinkFrog");

        if (pinkFrog == 1)
        {
            inventoryPFrog.SetActive(true); //turns on the skins button in our inventory/roster
        }

    }

    public void WearPFrog()
    {
        changePFrog = true;
    }
}
