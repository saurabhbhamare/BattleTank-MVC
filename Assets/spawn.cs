using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject blt; 
    void Start()
    {
       GameObject.Instantiate(blt, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
