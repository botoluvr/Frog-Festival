using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //this lets you call images which are used in the UI buttones (toggles)
using UnityEngine.SceneManagement; //this lets you call scenemanager which loads levels
using UnityEngine.Audio; //this calls the audio mixed

public class Notes2 : MonoBehaviour
{
    // rob time
    public Notes2 n2;
    public GameObject GO;
    public Image myimage;
    public Button mybutton;
    public float timer;
    // Start is called before the first frame update
    //AI
    //MOVE TOWARDS (move object towards another) flying follower enemy uses this
    public Vector3 start; // the start location
    public Vector3 finish; // the end location/target
    public float speed; //how fast the mover goes from start to finish
    //LOOT
    public GameObject money;

    //ARRAYS
    // an array is a collection of gameObjects and affect large groups of objects

    public GameObject[] alltheenemies; // the straight brackets signify a collection of gameobjects

    //PLAYER PREFS
    // playerprefs are values that will save even acter the player leaves the game. this is good for
    // unlockable content or overall progress. this can also work for character skins

    public int GreenBird; //this is not the player pref, just a normal int
    //example: the green bird unlocks after the first complete play through

    void Start()
    {
        PlayerPrefs.SetInt("GreenBird", 2); //this will unlock the green bird so i can only
        // do this when i am ready to unlock it. before this it would be set to 0 or 1

        if (PlayerPrefs.HasKey("GreenBird"))
        {
            GreenBird = PlayerPrefs.GetInt("GreenBird"); //if i beat the game it will change to 2, but
            // if i didn't yet, it will be 1
        }

        if(GreenBird == 2)
        {
            //i can select the greenbird
        }

        alltheenemies = GameObject.FindGameObjectsWithTag("enemy"); //this grabs all enemies
        //ENABLED VS SET ACTIVE
        // we enabled and disable components attached to gameObjects
        // we set active true or false entire gameObjects

        n2.enabled = true; // enabled the notes2 script (box collider, scripts, any component)
        GO.SetActive(true); // enabled the entire gameObject
        StartCoroutine(StarPower());// this line calls the IEnumerator (don't do this in update or it
        // will call forever and potentially crash or freeze your game)
    }

    // Update is called once per frame
    void Update()
    {
        //TIMERS
        //we can create timers using the command Time.deltaTime. this means time that has passed since
        //the last frame (so a constant timer). we can take a float and add/subtract Time.deltaTime to
        //create a timer that counts up or down
        timer -= Time.deltaTime; //-= subtracts time from timer consistently
        timer += Time.deltaTime; //-= adds time to timer consistently

        if (timer >= 0)
        {
            mybutton.interactable = true; //this allows the button to be pressed
        }

        if (timer < 0)
        {
            mybutton.interactable = false; //this greys the button out and disables it
        }

        Vector3.MoveTowards(start, finish, speed); //this line will move the object
        //the start position is set to the movers position
        //the target position is set to another gameobject (usually the player)
        //the speed is constant

        //INSTANTIATE
        //this is a way to make things appear in our scene, like enemy loot, or power ups

        GameObject loot = Instantiate(money, transform.position, transform.rotation);
        // the above line makes a new gameobject by creating money at our current location
        // we say GameObject loot because we are creating a new gameobject in the hierarchy called loot
        // money is usually a prefab that we can call over and over again
        // this means that money won't be in the hierarchy but inside the game's asset folder   
        Destroy(money, 5f); // this destroys the money if we don't get it fast enough (this isn't very mobile friendly)

        //AUTOPOOLING
        // we are using the plugin called Mob Farm Auto Pooler
        GameObject loot2 = MF_AutoPool.Spawn(money, transform.position, transform.rotation);
        // this is the mobile friendly version
        MF_AutoPool.Despawn(this.gameObject, 5f); // this line would be on the money gameObject
                                                  // put it back into the pool without any leftover issues/data/residue

        //ARRAY (how to go through your list and affect each object one at a time)
        //FOR LOOP
        for (int i = 0; i<alltheenemies.Length; i++)
        {
            alltheenemies[i].SetActive(true); //we set each enemy to active
        }
        // int i = 0 means we start at the top of the list
        // i < allenemies means as long as the number we're on isn't larger than the list
            // if the lsit is 10 long and we are at zero, 0<10 to we add one. 1<10 and so on, until 10
        // i++ we move down the list by one

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // this statement is used when we want the player to walk into a specific area and trigger something
        // this could be an animation, enemy, or anything else
        // an event is triggered when a player passes through a collider that is marked as a trigger
        // either the player or the collider must have a rigidbody in order for the hit to register

        if (collision.tag == "player")
        {
            //then we trigger the event, this will only trigger if the collider has the tag "player"
            //this is so that enemies can't trigger this event
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //unlike a trigger a collision happens when two colliders bump into each other but do not pass through
    }

    //CO-ROUTINES (which unity calls IEnumerator)
    // normal functions in unity are read top to bottom all at once. sometimes we want to pause before finishing the function,
    // which is when we use IEnumerator. think of this like the star in SMB: when you get the star you are temporarily invincible,
    // the sprite changes, the music changes, and then it eventually wears off

    public IEnumerator StarPower()
    {
        //give mario star power
        //change the music
        //change sprite graphics
        //then wait
        yield return new WaitForSeconds(5f); //this makes unity wait 5 seconds
                                             //power wears off
                                             //change music back
                                             //change sprite back
        yield return new WaitForSeconds(5f);

    }

    // to call an IEnumerator we need to use the word Co-Routine (see start loop)

}
