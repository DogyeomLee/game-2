using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paly180 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float _speed = 10;
    public float waitTime;

    private void Start()
    {
        
    }
    private void Update()
    {
        rotate();
    }
    void rotate()
    {
        transform.Rotate(new Vector3(0,0 ,_speed * Time.deltaTime ));
    }

}
