using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpNotes : MonoBehaviour
{
    // hi rob :) this is ari

    // Top part of the script is generally where we store the variables because we need
    // to call them here first if we want to manipulate them later in the script. Things 
    // like numbers, references to objects, or references to other scripts.

    // Variables have three parts, the first part is public or private, the second part is
    // the type of variable, and the third part is whatever we decide to name the variable.

    // NUMBER VARIABLES
    // There are two common types, floats and ints
    public float number;
    // Float stands for floating point number which means the number has a decimal point, like 1.25
    public int wholenumber;
    // 1, 2, and 3 are ints
    private float myhiddennumber;
    // A private variable is not visible inside the inspector

    // BOOLS are true/false statements
    public bool yesorno;
    // A bool is a binary y/n statement, like a lightswitch

    // Other common variables
    public GameObject mygameobject;
    // We can reference any object in our scene, all items in the hierarchy are considered gameobjects
    public CSharpNotes CSN;
    // We can also reference any script that we have written as long as it is public
    public Rigidbody2D myRB2D;
    // We use rigid bodies on players, enemies, and anything you want to be affected by unity's physics
    public BoxCollider2D myboxcollider;
    public CircleCollider2D mycirclecollider;
    // We can also reference colliders of all types
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Anything you want to happen when the game first starts goes in here
        // Sometimes we don't want to manually add items to the inspector
        // Sometimes we want new items to spawn during gameplay
        // In this case we can use a few simple commands to have the script automatically find objects

        myRB2D = GetComponent<Rigidbody2D>();
        // This will get the rigid body, but only if it's on the same object as our script
        myRB2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        // This will find any object in our scene with the tag "player" and get its rigidbody
        myRB2D = GameObject.FindObjectOfType<Rigidbody2D>();
        // This only works when where is no more than one rigidbody

        // When the game starts we might also want to look at a few different properties of our gameobjects
        // Transform, position, rotation, and scale
        transform.position = new Vector2(0, 0);
        // The transform position is location on x and y
        // Transforms are read by unity as a Vector (vector 2 and vector 3), X is horizontal and Y is vertical
        // The vector 2 above is at origin position
        transform.position = new Vector2(24, 128);
        // This would move us 24 units right and 128 units up
        transform.localScale = new Vector2(0, 0); //2D
        transform.localScale = new Vector3(0, 0, 0); //3D
        // Both these scales would be invisible
        transform.rotation = Quaternion.Euler(0, 0, 0);
        // We use quaternions and EULERs (oilers) for rotation
    }

    // Update is called once per frame
    void Update()
    {
        // Inside the update function we call things that we want to update in real time as we play the game
        
        //IF STATEMENTS
        if (yesorno == true)
        {
            // we say yes, the player Lives
        }

        if (yesorno == false)
        {
            // we say no, the player dies
        }
        // This is an example of how bools can work. If the bool is trye one thing happens, if it's falst something else happens
        // For the if statement we need a double equal sign. '=' means it is true or false. '==' makes the program check to see if it is true or false.

        if(number >=10)
        {
            // we do something epic
        }

        // We can also use if statements to control the player
        if(Input.GetAxis("Horizontal") > 0)
        {
            // we move the player
            myRB2D.velocity = new Vector2(25, 0);
        }

        if(Input.GetAxis("Horizonal") == 0)
        {
            // we stop the player
            myRB2D.velocity = new Vector2(0, 0); // this is a zero velocity
            // to see all the different rigidbody options just start typing "myRB2D"
            myRB2D.gravityScale = .5f; // gives me half gravity
            myRB2D.simulated = false; // this means the rigid body is no longer affecter by the physics engine
            myRB2D.isKinematic = true; // kinematic rigidbody only moves if the code tells it to
            myRB2D.isKinematic = false; // non kinematic is the same as dynamic which means its affected by the physics engine
        }

        // IF ELSE STATEMENTS
        // If statements get read one after the other which can sometimes cause weird behavior
        // We can avoid this by using IF ELSE statements

        if (yesorno == true)
        {
            // we say yes, the player Lives
        }

        else if (yesorno == false)
        {
            // we say no, the player dies
        }

        // Because this code is in the update look changes can happen quickly and unity can cycle through multiple if statements
        // faster than we sometimes want to. This is why we use else

        public void FixedUpdate()
         {
             // Regular update is based on frame rate (older computers will run the code slower). This is not ideal
             // Most graphical elements can live inside the update loop without any issue. The fixed update look is used for physics
             // calculations as it's called on a set interval which means that all computers run the code at the same speed
         }

    }
}
