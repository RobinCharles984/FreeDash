using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool menu = false;
    public Canvas canvas;
    public GameObject nextLevel;
    public GameObject nextLevelLock;
    public GameObject player;
    public AudioSource audio;
    public float coin = 0;
    public bool nextLevelUnlock = false;

    private void Start()
    {
        canvas.enabled = false;
        nextLevel.SetActive(false);
        nextLevelLock.SetActive(true);
    }

    private void Update()
    {
        //If press ESC, pause menu appears and game freeze
        if (Input.GetKeyDown(KeyCode.Escape) && menu == false)
        {
            menu = true;
            canvas.enabled = true;
            audio.enabled = false;
            Time.timeScale = 0;
            Debug.Log("Paused");
        }        
        else if (Input.GetKeyDown(KeyCode.Escape) && menu == true)
        {
            menu = false;
            audio.enabled = true;
            Time.timeScale = 1;
            canvas.enabled = false;
            Debug.Log("Unpaused");
        }

        //Unlocking Next Level Button
        bool unlocker = player.GetComponent<Scr_Player_Move>().nextLevel;
        if (unlocker == true)//Only appears if player reaches the end of the level
        {
            nextLevel.SetActive(true);
            nextLevelLock.SetActive(false);
        }
    }

    //Next Level Button
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Restart Button
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        Debug.Log("Level Restarted");
    }

    //Exit Button
    public void Exit()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Returned to Main Menu");
    }
}
