using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_CoinManager : MonoBehaviour
{
    public Text text;
    public GameObject player;
    public Text timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float coin = player.GetComponent<Scr_Player_Move>().coin;//Taking coin from player script
        text.text = "Coins = " + coin.ToString();

        timer.text = "Time = " + Time.deltaTime;
    }
}
