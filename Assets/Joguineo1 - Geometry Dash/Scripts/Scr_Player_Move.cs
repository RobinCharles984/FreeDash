using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player_Move : MonoBehaviour
{
    //PowerUp Variables
    public bool invincible = false;
    public float invincibleTimeS;
    public bool slow = false;
    private float cronometro = 0;

    //Ground Variables
    public bool isGrounded1;
    public bool isGrounded2;
    public Transform groundCheck1;
    public Transform groundCheck2;
    public LayerMask groundLayer;

    //Dead Variables
    public bool Dead = false;
    private SpriteRenderer sprender;
    public GameObject deadEffect;

    //Movement Variables
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool gravity = true;
    
    //Game Manager Variables
    public float coin;
    public bool nextLevel = false;

    //Sound Manager Variables
    public AudioClip SfxJump, SfxDead, SfxCoin;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        sprender = GetComponent<SpriteRenderer>();
        deadEffect.SetActive(false);
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        bool jump = Input.GetKeyDown(KeyCode.Space);
        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        //if it's grounded and press jump key
        if(isGrounded1 && jump && Dead == false)
        {
            rb.velocity = Vector2.up * jumpForce;

            audioSource.PlayOneShot(SfxJump);//Play jump sound
        }

        if (isGrounded2 && jump && Dead == false)
        {
            rb.velocity = Vector2.up * jumpForce;
            
            audioSource.PlayOneShot(SfxJump);//]Play jump sound
        }
    }

    private void FixedUpdate()
    {
        isGrounded1 = Physics2D.OverlapCircle(groundCheck1.position, 0.1f, groundLayer);
        isGrounded2 = Physics2D.OverlapCircle(groundCheck2.position, 0.1f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ////////////////////////////////////Collide with portal/////////////////////////////////////////////////
        if (collision.gameObject.layer == 3 && gravity == true)
        {
            rb.gravityScale *= -1;
            jumpForce *= -1;
            gravity = false;
            Debug.Log("Gravity Inverted");
        }
        else if (collision.gameObject.layer == 3 && gravity == false)
        {
            rb.gravityScale *= -1;
            jumpForce *= -1;
            gravity = true;
            Debug.Log("Gravity Normal");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////Collide with spike/////////////////////////////////////////////////
        if (collision.gameObject.layer == 6 && Dead == false && invincible == false)
        {
            speed = 0;
            sprender.enabled = false;
            jumpForce = 0;
            Dead = true;

            audioSource.PlayOneShot(SfxDead);//Play death sound

            deadEffect.SetActive(true);
            Debug.Log("Dead = " + Dead);
            Destroy(deadEffect, 500);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////Collide with Invincible PowerUp/////////////////////////////////////////////////

        if (collision.gameObject.layer == 7 && invincible == false)
        {
            invincible = true;
            Debug.Log("Invincible = " + invincible);
            cronometro += Time.deltaTime;
            while(invincibleTimeS >= cronometro)
            {
                invincibleTimeS--;
                Debug.Log("Invincible left = " + invincibleTimeS);
            }
            invincible = false;
            Debug.Log("Invincible = " + invincible);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////Collide with Slow PowerUp/////////////////////////////////////////////////
        if (collision.gameObject.layer == 7 && slow == false)
        {
            slow = true;
            Debug.Log("SlowMotion = " + slow);
            cronometro += Time.deltaTime;
            while (invincibleTimeS >= cronometro)
            {
                invincibleTimeS--;
                Debug.Log("Invincible left = " + invincibleTimeS);
            }
            invincible = false;
            Debug.Log("Invincible = " + invincible);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////Collide with Coin/////////////////////////////////////////////////
        if (collision.gameObject.layer == 11)
        {
            audioSource.PlayOneShot(SfxCoin);//Play coin sound

            coin++;
            Debug.Log("Actual coins = " + coin);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////Collide with LevelEnd/////////////////////////////////////////////////
        if (collision.gameObject.layer == 12 && nextLevel == false)
        {
            nextLevel = true;
            Debug.Log("Next Level Unlocked");
        }
    }
}
