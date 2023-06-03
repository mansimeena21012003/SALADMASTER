using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsControl : MonoBehaviour
{
    
    public static int points = 0;
    void Start()
    {
        points = 0;
    }
    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("points"))
        {
            Destroy(coll.gameObject);
           
            points++;
        }
    }
}
