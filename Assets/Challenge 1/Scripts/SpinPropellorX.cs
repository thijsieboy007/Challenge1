using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellorX : MonoBehaviour
{
    private float Speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Speed);
    }
}
