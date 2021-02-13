using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMarks : MonoBehaviour
{
    public int number_marks_final;
    public int number_marks1;
    public int number_marks2;
    public int number_marks3;

    void Start()
    {
        Debug.Log("Start");
        number_marks_final = 0;
        number_marks1 = 0;
        number_marks2 = 0;
        number_marks3 = 0;
    }

    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name.Contains("Sphere1"))
        {
            number_marks1++;
            Destroy(gameObject);
          //  Debug.Log("first"+number_marks1);
        }
        if (gameObject.name.Contains("Sphere2"))
        {
            number_marks2++;
            Destroy(gameObject);
         //   Debug.Log("second"+number_marks2);
        }
        if (gameObject.name.Contains("Sphere3"))
        {
            number_marks3++;
            Destroy(gameObject);
         //   Debug.Log("third"+number_marks3);
        }
        number_marks_final = FindObjectOfType<StoreMarksVariable>().stored_variable_marks;
       // Debug.Log("final"+number_marks_final);

    } 
}
