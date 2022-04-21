using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spite : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rBody;
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        this.transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "under")
        {

            speed = 3;
        }
        else if (collision.gameObject.tag == "up")
        {

            speed = -3;
        }
    }


}
