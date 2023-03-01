using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_CoinMnnTimerMn : MonoBehaviour
{
    public Text text;
    public GameObject player;
    public Text timer;
    private float seconds = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float coin = player.GetComponent<Scr_Player_Move>().coin;//Taking coin from player script
        text.text = "Coins = " + coin.ToString();

        seconds += Time.deltaTime * 1.0f;
        timer.text = "Time = " + seconds.ToString("F0");
    }
}
