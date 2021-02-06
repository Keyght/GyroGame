using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MooveTheCamera : MonoBehaviour
{
    public GameObject Camera_obj;
    CharacterController _charactercontroller;
    public float speedrotation;
    private float speed; //Скорость перемещения
    public int ii;

    void Start()
    {
        _charactercontroller = Camera_obj.GetComponent<CharacterController>();
        speed = 1;
        speedrotation = 3;
        ii = 0;
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * speedrotation, 0);
        //if (Input.GetMouseButtonDown(0))
        //{

        //}
        ii = FindObjectOfType<MooveButtons>().i;
        //Двигаемся вперед по вектору камеры
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            _charactercontroller.SimpleMove(forward * speed);
        }
        //Движение назад по вектору камеры
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            _charactercontroller.SimpleMove(-forward * speed);
        }


        if (ii == 1)
        {
            Debug.Log("MooveTheCamera ww" + ii);
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            _charactercontroller.SimpleMove(forward * speed);
            ii = 0;

        }
        //Движение назад по вектору камеры
        if (ii == -1)
        {
            Debug.Log("MooveTheCamera ss" + ii);
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            _charactercontroller.SimpleMove(-forward * speed);

        }
    }
}
