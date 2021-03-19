using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.position, .15f);
    }
}
