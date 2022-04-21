using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    GameObject fp;
    GameObject mp;
    GameObject bp;
    GameObject cp;
    GameObject fhp;
    GameObject rp;
    GameObject shp;

    // Start is called before the first frame update
    void Start()
    {
        fp.SetActive(false);
        mp.SetActive(false);
        bp.SetActive(false);
        cp.SetActive(false);
        fhp.SetActive(false);
        rp.SetActive(false);
        shp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
