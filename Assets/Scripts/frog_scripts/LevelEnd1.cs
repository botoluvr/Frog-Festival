using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine;

public class LevelEnd1 : MonoBehaviour {

	public string levelToLoad;

    public CinemachineVirtualCamera cvc;

	//public PlayerController thePlayer;
	//public CameraController theCamera;
	//public LevelManager theLevelManager;

	public float waitToMove;
	public float waitToLoad;
	private bool movePlayer;

	public GameObject pauseScreen;
    public GameObject LevelEndScreen;

    public bool tutorial;

	// Use this for initialization
	void Start () {

       
        

    }
	
    IEnumerator FindPlayer()
    {
        yield return new WaitForSeconds(.25f);
   
    }
	// Update is called once per frame
	void Update () {
       // thePlayer = FindObjectOfType<PlayerController>();
        if (movePlayer) 
		{
		//	thePlayer.myRigidBody.velocity = new Vector3 (thePlayer.moveSpeed, thePlayer.myRigidBody.velocity.y, 0f);
		}
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.tag == "Player")
		{
            SceneManager.LoadScene(levelToLoad);
            LevelEnd();
        }

        if (tutorial == true)
        {
            PlayerPrefs.SetInt("LvlStart", 1);
        }

    }

    public void LevelEnd()
    {
        cvc.enabled = false;
        //thePlayer.canMove = false;
        //theCamera.followTarget = false;
        //pauseScreen.SetActive (false);
        //theLevelManager.invincible = true;
        //thePlayer.myRigidBody.velocity = Vector3.zero;

        //PlayerPrefs.SetInt ("CoinCount", theLevelManager.coinCount);
        //PlayerPrefs.SetInt ("PlayerLives", theLevelManager.currentLives);
        PlayerPrefs.SetInt("GB", 2);

        //theLevelManager.levelMusic.Stop ();
        //theLevelManager.gameOverMusic.Play ();

        //yield return new WaitForSeconds(waitToMove);
        // movePlayer = true;

        LevelEndScreen.SetActive(true);
        //yield return new WaitForSeconds(waitToLoad);
        //SceneManager.LoadScene(levelToLoad);
    }
}
