using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BallSpawn : MonoBehaviour
{
    public GameObject[] balls;
    GameObject ball;
    public float timer;
    public float timerReset;

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Spawn();
            timer = timerReset;
        }
    }
    // Update is called once per frame
     
    public void Spawn()
    {
        ball = balls[Random.Range(0, 6)];
        var position = new Vector2(Random.Range(-11.0f, 11.0f), this.transform.position.y);
        Instantiate(ball, position, Quaternion.identity);
    }
}
