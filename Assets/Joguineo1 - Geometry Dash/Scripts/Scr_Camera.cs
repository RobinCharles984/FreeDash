using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Camera : MonoBehaviour
{

    public Transform player;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;//Just defines that camera is the main
    }

    // Update is called once per frame
    void Update()
    {
        float camx = player.transform.position.x;
        float camy = player.transform.position.y;

        //Position of the camera is equals to position x and y of the player, simple
        transform.position = new Vector3(camx, camy, -40);
    }
}
