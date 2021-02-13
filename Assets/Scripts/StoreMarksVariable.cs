using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreMarksVariable : MonoBehaviour
{
    public int stored_variable_marks;
    public int stored_variable1;
    public int stored_variable2;
    public int stored_variable3;

    void Start()
    {
        stored_variable_marks = 0;
        stored_variable1 = 0;
        stored_variable2 = 0;
        stored_variable3 = 0;
    }

    void Update()
    {
        if (stored_variable1 == 0)
        {
            stored_variable1 = FindObjectOfType<DestroyMarks>().number_marks1;
        }
        if (stored_variable2 == 0)
        {
            stored_variable2 = FindObjectOfType<DestroyMarks>().number_marks2;
        }
        if (stored_variable3 == 0)
        {
            stored_variable3 = FindObjectOfType<DestroyMarks>().number_marks3;
        }
        stored_variable_marks = stored_variable1 + stored_variable2 + stored_variable3;
        Debug.Log("final second file " + stored_variable_marks);

    }
}
