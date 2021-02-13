using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMarks : MonoBehaviour
{
    public int number_marks;
    public int number_marks1;
    public int number_marks2;
    public int number_marks3;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        //number_marks = 0;
        //number_marks1 = 0;
        //number_marks2 = 0;
        //number_marks3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name.Contains("Sphere1"))
        {
            number_marks1++;
            Destroy(gameObject);
            Debug.Log("first"+number_marks1);
        }
        if (gameObject.name.Contains("Sphere2"))
        {
            number_marks2++;
            Destroy(gameObject);
            Debug.Log("second"+number_marks2);
        }
        if (gameObject.name.Contains("Sphere3"))
        {
            number_marks3++;
            Destroy(gameObject);
            Debug.Log("third"+number_marks3);
        }
        number_marks = number_marks1 + number_marks2 + number_marks3;
        Debug.Log("final"+number_marks);

    } 
}
