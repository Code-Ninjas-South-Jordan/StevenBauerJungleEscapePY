using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    // private bool RayCast = Physics.Raycast( , Vector3.forward, 10f);

    void Update()
    {
        if (Physics.Raycast(transform.position, Vector3.down, 300f, 1 << LayerMask.NameToLayer("RayLayer")))
        {
            Debug.Log("I hope this works lol");
        }

    }

    void FixedUpdate()
    {
        
    }
}
