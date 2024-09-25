using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PRODUCTPLACEMENTYEAHHHH : MonoBehaviour
{
    public energy energy;
    public uint energyReset = 9999;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        energy.energyCount = energyReset;
        Debug.Log("shlurp");
        Destroy(gameObject);
    }
}
