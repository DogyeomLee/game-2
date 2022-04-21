using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermove : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody2D rBody;
    public Animator anim;
    public SpriteRenderer sr;
    public float horiz;
    private bool isGrounded = false;
    public float jumpForce = 30.0f;
    bool jumping = false;

    private GameObject contactPlatform;
    private Vector3 platformPosition;
    private Vector3 distance;

    //ui
    public GameObject fp;
    public GameObject mp;
    public GameObject bp;
    public GameObject cp;
    public GameObject fhp;
    public GameObject rp;
    public GameObject shp;
    public GameObject gj;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        jumping = false;
        fp.SetActive(false);
        mp.SetActive(false);
        bp.SetActive(false);
        cp.SetActive(false);
        fhp.SetActive(false);
        rp.SetActive(false);
        shp.SetActive(false);
        gj.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        jump();


        horiz = Input.GetAxis("Horizontal");

        //Jump

        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);
        Flip();

        anim.SetFloat("xSpeed", Mathf.Abs(rBody.velocity.x));
        anim.SetFloat("ySpeed", rBody.velocity.y);
        anim.SetBool("isGrounded", isGrounded);

    }
    public void Flip()
    {
        if (horiz > 0)
        {
            sr.flipX = false;
        }

        if (horiz < 0)
        {
            sr.flipX = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("play");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            isGrounded = true;
            jumping = false;
        }
        if (collision.gameObject.tag == "jumpPlatform")
        {
            isGrounded = true;
            jumpForce = 17;
            jumping = true;
            rBody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
        else
        {
            jumpForce = 10;
        }
        if(collision.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene("play");
        }
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("play");
        }
        if (collision.gameObject.tag == "Finish")
        {
            gj.SetActive(true);
            fp.SetActive(false);
            mp.SetActive(false);
            bp.SetActive(false);
            cp.SetActive(false);
            fhp.SetActive(false);
            rp.SetActive(false);
            shp.SetActive(false);
        }
        if (collision.gameObject.tag == "Ground")
        {
            fp.SetActive(true);
            mp.SetActive(false);
            bp.SetActive(false);
            cp.SetActive(false);
            fhp.SetActive(false);
            rp.SetActive(false);
            shp.SetActive(false);
            gj.SetActive(false);
        }
        if (collision.gameObject.tag == "fall")
        {
            cp.SetActive(true);
            fp.SetActive(false);
            mp.SetActive(false);
            bp.SetActive(false);
            fhp.SetActive(false);
            rp.SetActive(false);
            shp.SetActive(false);
            gj.SetActive(false);
        }
        if (collision.gameObject.tag == "moce")
        {
            mp.SetActive(true);
            fp.SetActive(false);
            bp.SetActive(false);
            cp.SetActive(false);
            fhp.SetActive(false);
            rp.SetActive(false);
            shp.SetActive(false);
            gj.SetActive(false);
        }
        if (collision.gameObject.tag == "FHP")
        {
            fhp.SetActive(true);
            fp.SetActive(false);
            mp.SetActive(false);
            bp.SetActive(false);
            cp.SetActive(false);
            rp.SetActive(false);
            shp.SetActive(false);
            gj.SetActive(false);
        }
        if (collision.gameObject.tag == "car")
        {
            rp.SetActive(true);
            fp.SetActive(false);
            mp.SetActive(false);
            bp.SetActive(false);
            cp.SetActive(false);
            fhp.SetActive(false);
            shp.SetActive(false);
            gj.SetActive(false);
        }
        if (collision.gameObject.tag == "shp")
        {
            shp.SetActive(true);
            fp.SetActive(false);
            mp.SetActive(false);
            bp.SetActive(false);
            cp.SetActive(false);
            fhp.SetActive(false);
            rp.SetActive(false);
            gj.SetActive(false);
        }
        if (collision.gameObject.tag == "jumpPlatform")
        {
            bp.SetActive(true);
            fp.SetActive(false);
            mp.SetActive(false);
            cp.SetActive(false);
            fhp.SetActive(false);
            rp.SetActive(false);
            shp.SetActive(false);
            gj.SetActive(false);
        }

    }
    void jump()
     {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!jumping)
            {
                jumping = true;
                rBody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            }
        }
       else
        {
            return;
        }

    }
}
