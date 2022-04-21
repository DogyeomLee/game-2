using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    Rigidbody2D rBody;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(new Vector3(1 * speed, 0, 0) * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject player = other.gameObject;
            player.transform.SetParent(this.transform, true);
            speed = 7;
        }
    }
private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject player = other.gameObject;
            player.transform.SetParent(null);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "de1")
        {
            speed = 4;
        }
        else if (collision.gameObject.tag == "de2")
        {
            speed = 2;
        }
        else if (collision.gameObject.tag == "de3")
        {
            speed = 0;
        }
    }
}
