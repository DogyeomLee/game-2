using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabe : MonoBehaviour
{
    public GameObject player;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.transform.position + new Vector3(x, y, z);
    }
}
