using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int _hitCount = -1;
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            _hitCount ++;
            Debug.Log(message: "This is how many times you have hit the walls: "  + _hitCount);
        }
        
    }
}

