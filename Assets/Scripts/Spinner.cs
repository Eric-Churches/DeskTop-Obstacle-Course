using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float spinnerAxisX;
    [SerializeField] private float spinnerAxisY = 0.5f;
    [SerializeField] private float spinnerAxisZ;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinnerAxisX, spinnerAxisY, spinnerAxisZ);
    }
}
