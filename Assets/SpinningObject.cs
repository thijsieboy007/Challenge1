using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    private float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Speed, 0, 0);
    }
}
