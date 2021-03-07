using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public GameObject Camera_obj;
    CharacterController _charactercontroller;
    public float speedrotation;
    private float speed; //Скорость перемещения
    public void onClick()
    {
        Debug.Log("клик");

    }

    void Start()
    {
        _charactercontroller = Camera_obj.GetComponent<CharacterController>();
        speed = 1;
        speedrotation = 3;
    }
    public bool Pressed = false;
    public void onDown()
    {
        Pressed = true;
    }

    public void onUp()
    {
        Pressed = false;
    }

    void Update()
    {
       // transform.Rotate(0, Input.GetAxis("Horizontal") * speedrotation, 0);
        if (Pressed) {
            Debug.Log("Кнопка нажата");
            
            Vector3 forward = Camera_obj.transform.TransformDirection(Vector3.forward);
            _charactercontroller.SimpleMove(-forward * speed);
        }
    }
}
