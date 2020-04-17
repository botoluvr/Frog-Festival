using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cinemachine;

public class LevelEnd2 : MonoBehaviour {

    public string levelToLoad;

    public SimpleController thePlayer;
    //public CameraController theCamera;
    //public LevelManager theLevelManager;

    public CinemachineVirtualCamera cvc;

    public float waitToMove;
    public float waitToLoad;
    private bool movePlayer;

    public bool tutorial;

    public float combo;
    public Text comboText;
    public GameObject pauseScreen;
    public GameObject LevelEndScreen;
    public Text finalCombo;

    public float score;
    public float scoretobeatlevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
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
