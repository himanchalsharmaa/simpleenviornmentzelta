using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj3changeSize : MonoBehaviour
{
    Vector3 initial;
    bool increasing = false;
    bool decreasing = false;
    public GameObject cond1;
    public GameObject cond2;
    void Start()
    {
        initial = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        
        if (transform.localScale != Vector3.one)
        {
            if (increasing)
            {
                increasing = false;
                decreasing = true;
                StopCoroutine("increasesize");
                StartCoroutine("decreasesize");
            }
            else if (decreasing)
            {
                decreasing = false;
                increasing = true;
                StopCoroutine("decreasesize");
                StartCoroutine("increasesize");
            }

        }
        else if(cond1.GetComponent<Renderer>().material.color == Color.green && !cond2.GetComponent<obj2Changerotation>().rotating)
        {
                increasing = true;
                StartCoroutine("increasesize");
         
        }
    }

    IEnumerator increasesize()
    {
            while (transform.localScale.x < 2)
            {
            Debug.Log("here1");
            transform.localScale = Vector3.MoveTowards(transform.localScale, 2 * Vector3.one, Time.deltaTime * 0.5f);
                yield return new WaitForSeconds(0.01f);
            }
            yield return null;
    }
    IEnumerator decreasesize()
    {
        while (transform.localScale.x > 1)
        {
            Debug.Log("here2");
            transform.localScale = Vector3.MoveTowards(transform.localScale, Vector3.one, Time.deltaTime * 0.5f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return null;
    }
}
