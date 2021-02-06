using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speedrotation;
    // Start is called before the first frame update
    void Start()
    {
        speedrotation = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * speedrotation, 0);
    }
}
