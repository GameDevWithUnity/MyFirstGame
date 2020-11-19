using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseclickmover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousecor = Input.mousePosition;
        Vector3 mouseco = Camera.main.ScreenToWorldPoint(mousecor);
        mouseco.z =transform.position.z;
        transform.position = mousecor;

    }
}
