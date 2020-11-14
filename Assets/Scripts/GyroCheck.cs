using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCheck : MonoBehaviour
{
   // public GameObject player; // First Person Controller parent node
    public GameObject head; // First Person Controller camera

    private int initialOrientationX;
    private int initialOrientationY;
    private int initialOrientationZ;

   // public void ReturnToPreviosRotate(){
      //  head.transform.eulerAngles = new Vector3(0, 0, 0);
   // }

    void Start() {
        Input.gyro.enabled = true;
        initialOrientationX = (int)Input.gyro.rotationRateUnbiased.x;
        initialOrientationY = (int)Input.gyro.rotationRateUnbiased.y;
        initialOrientationZ = (int)(-Input.gyro.rotationRateUnbiased.z);
    }

    void FixedUpdate()
    {
        //player.transform.Rotate(0, initialOrientationY - Input.gyro.rotationRateUnbiased.y, 0);
        //head.transform.Rotate(initialOrientationX - Input.gyro.rotationRateUnbiased.x, 0, initialOrientationZ + Input.gyro.rotationRateUnbiased.z);
        //  player.transform.position = new Vector3(0,0 , 0);
        head.transform.Rotate((initialOrientationX - Input.gyro.rotationRateUnbiased.x)/2, (initialOrientationY - Input.gyro.rotationRateUnbiased.y) / 2, 0);
     

    }

}
