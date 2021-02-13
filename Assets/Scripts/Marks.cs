using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marks : MonoBehaviour
{
    public Button mybuttonblue;
    public Button mybuttonpink;
    public GameObject mybuttonblue_obj;
    public GameObject mybuttonpink_obj;
    public int number_blue;
    public int number_pink;
    public int summ_marks;
    // Start is called before the first frame update
    void Start()
    {
        mybuttonblue.onClick.AddListener(whattodoblue);
        mybuttonpink.onClick.AddListener(whattodopink);
        summ_marks = 0;
    }
    public void whattodoblue()
    {
        number_blue = 1;
        Destroy(mybuttonblue_obj);
        Debug.Log("blue" + number_blue);
        if ((number_blue==1)&&(number_pink==1))
        {
            summ_marks = number_blue + number_pink;
            Debug.Log("summ"+ summ_marks);
        }
    }
    public void whattodopink()
    {
        number_pink = 1;
        Destroy(mybuttonpink_obj);
        Debug.Log("pink" + number_pink);
        if ((number_blue == 1) && (number_pink == 1))
        {
            summ_marks = number_blue + number_pink;
            Debug.Log("summ" + summ_marks);
        }
    }
    void Update()
    {

    }
}
    

