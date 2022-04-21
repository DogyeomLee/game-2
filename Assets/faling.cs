using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faling : MonoBehaviour
{
    public float fallTime = 0.5f, destroyTime = 2f, spawnTime = 2f;
    Rigidbody2D rb;

    public GameObject platform;
    public float posX1, posY;
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag ==("Player"))
        {
            StartCoroutine("spawnPlatform", new Vector2(transform.position.x, transform.position.y));
            Invoke("Fallplatform", fallTime);
            Destroy(gameObject, destroyTime);
            ani.SetBool("playergrounded", true);
        }
        else
        {
            ani.SetBool("playergrounded", false);
        }
    }
    void Fallplatform()
    {
        rb.isKinematic = false;
    }
    IEnumerator spawnPlatform(Vector2 spawnPos)
    {
        yield return new WaitForSeconds(spawnTime);
        Instantiate(platform, spawnPos, platform.transform.rotation);
    }
}
