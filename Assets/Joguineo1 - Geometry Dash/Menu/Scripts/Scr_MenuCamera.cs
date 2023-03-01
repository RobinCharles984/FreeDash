using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MenuCamera : MonoBehaviour
{

    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float timeleft = 2;
        float time = timeleft;

        timeleft -= Time.deltaTime;

    }
}
