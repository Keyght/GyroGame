using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MooveButtons : MonoBehaviour
{
    public Button mybuttonww;
    public Button mybuttonss;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        mybuttonww.onClick.AddListener(whattodoww);
        mybuttonss.onClick.AddListener(whattodoss);
    }
    public void whattodoww()
    {
        i = 1;
        Debug.Log("MooveButtons ww" + i);
    }


    public void whattodoss()
    {
        i = -1;
        Debug.Log("MooveButtons ss" + i);
    }
    public void itoonull() {
        i = 0;
    }
    // Update is called once per frame
    void Update()
    {
       // i = FindObjectOfType<MooveTheCamera>().ii;
    }
}
