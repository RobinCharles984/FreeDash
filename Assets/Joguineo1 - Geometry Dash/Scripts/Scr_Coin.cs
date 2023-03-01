using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
