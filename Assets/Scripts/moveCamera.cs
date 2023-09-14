using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    float speed = 3.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rotatecam());
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position,new Vector3(5.5f, 2f, 1.3f), step);
     
    }

    IEnumerator rotatecam()
    {
        while (transform.rotation.y != -180)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, -180f, 0f), 1.0f* Time.deltaTime);
            yield return null;
        }
        transform.rotation = Quaternion.Euler(0f, -180f, 0f);
        yield return null;
    }
}
