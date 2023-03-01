using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scr_Menu : MonoBehaviour
{
    public GameObject ball;
    ////////////////////////////////////Main Menu/////////////////////////////////////////
    public void Play()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", true);
    }

    public void Options()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", true);
    }

    public void Exit()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", true);
        Application.Quit();
    }

    public void Back()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
    }
    ////////////////////////////////////Play Menu/////////////////////////////////////////
    public void Level1()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
        SceneManager.LoadScene(3);
    }

    public void Level4()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
        SceneManager.LoadScene(4);
    }

    public void Level5()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
        SceneManager.LoadScene(5);
    }

    public void Level6()
    {
        Animator anim = ball.GetComponent<Animator>();
        anim.SetBool("Menu", false);
        SceneManager.LoadScene(6);
    }

    ////////////////////////////////////Options Menu/////////////////////////////////////////
    
}
