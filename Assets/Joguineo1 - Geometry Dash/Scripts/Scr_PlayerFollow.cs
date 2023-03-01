using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlayerFollow : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position;
    }
}
