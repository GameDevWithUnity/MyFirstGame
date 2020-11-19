using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboardclickmover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float stepsize = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -stepsize, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, stepsize, 0);
        }
    }
}
