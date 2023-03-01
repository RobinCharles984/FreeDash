using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_DestroyMenuBalls : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
