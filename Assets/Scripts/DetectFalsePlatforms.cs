using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool didRayHit;
    private bool CastRays = true;

    void Update()
    {
        // didRayHit = Physics.Raycast(transform.postition, Vector3.forward, 10f);
        // Debug.DrawRay(transform.position, Vector3.forward, Color.red, 10f);

        if(CastRays)
        {
            if(Physics.Raycast(transform.position, Vector3.forward, 10f))
            {
                if(transform.gameObject.layer == 8)
                {
                    Debug.Log("WATCH OUT!!!");
                } else 
                {
                    Debug.Log("you SHOULD be okay...");
                }
            }
        }
    }
    
    // public bool hit;
    // public int layerCatch;
    // void Update()
    // {
    //     hit = Physics.Raycast(transform.position, transform.position, .15f);
    //     layerCatch = FindGameObjectsWithLayer(8);

    //     if(layerCatch == 8)
    // }

    // GameObject[] FindGameObjectsWithLayer (int layer) 
    // { 
    //     GameObject[] goArray = FindObjectsOfType(typeof(GameObject)) as GameObject[]; 
    //     List goList = new List(); 
    //     for (int i = 0; i < goArray.Length; i++) 
    //     { 
    //         if (goArray[i].layer == layer) 
    //         { 
    //             goList.Add(goArray[i]); 
    //         } 
    //     } 
    //     if (goList.Count == 0) 
    //     { 
    //         return null; 
    //     } 
    //     return goList.ToArray(); 
    //     }
}
