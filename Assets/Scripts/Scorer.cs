using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit") 
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
    }
}
