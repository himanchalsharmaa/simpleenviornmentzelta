using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj1changeColor : MonoBehaviour
{
    bool changed = false;
    private Color changeColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (changed)
        {
            changeColor = Color.blue;
        }
        else
        {
            changeColor = Color.green;
        }
        gameObject.GetComponent<Renderer>().material.color = changeColor;
        changed = !changed;
    }
}
