using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardsmoothmover : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -Time.deltaTime*speed, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, Time.deltaTime * speed, 0);
        }
    }
}
