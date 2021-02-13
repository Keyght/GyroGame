using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMarks : MonoBehaviour
{
    public int number_marks;
    public int number_marks1;
    public int number_marks2;
    public int number_marks3;
    public void set_number_marks(int number_marks)
    {
        this.number_marks = number_marks;
    }
    public void set_number_marks1(int number_marks1)
    {
        this.number_marks1 = number_marks1;
    }
    public void set_number_marks2(int number_marks2)
    {
        this.number_marks2 = number_marks2;
    }
    public void set_number_marks3(int number_marks3)
    {
        this.number_marks3 = number_marks3;
    }
    public DestroyMarks(int number_marks, int number_marks1, int number_marks2, int number_marks3)
    {
        this.number_marks = number_marks;
        this.number_marks1 = number_marks1;
        this.number_marks2 = number_marks2;
        this.number_marks3 = number_marks3;
    }
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
        DestroyMarks destroyMarks = new DestroyMarks(0, 0, 0, 0);
        destroyMarks = gameObject.AddComponent<DestroyMarks>();
        if (gameObject.name.Contains("Sphere1"))
        {
            destroyMarks.set_number_marks1(1);
            Destroy(gameObject);
            Debug.Log("first"+number_marks1);
        }
        if (gameObject.name.Contains("Sphere2"))
        {
            destroyMarks.set_number_marks2(1);
            Destroy(gameObject);
            Debug.Log("second"+number_marks2);
        }
        if (gameObject.name.Contains("Sphere3"))
        {
            destroyMarks.set_number_marks3(1);
            Destroy(gameObject);
            Debug.Log("third"+number_marks3);
        }
        destroyMarks.set_number_marks(number_marks1 + number_marks2 + number_marks3);
        Debug.Log("final"+number_marks);

    } 
}
