    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj2Changerotation : MonoBehaviour
{
    [System.NonSerialized]
    public bool rotating = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (!rotating)
        {
            rotating = true;
            StartCoroutine(beginRotation());
            
        }
        else
        {
            StopCoroutine(beginRotation());
            rotating = false;
        }
    }

    IEnumerator beginRotation()

    {
        while (rotating) { transform.Rotate(0, Time.deltaTime * 100, 0); yield return new WaitForSeconds(0.01f); }
        yield return null;
        
    }
}
