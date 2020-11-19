using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float accelator = 1f;
    // Update is called once per frame
    void Update()
    {
        GetComponent<Mover>().addSpeed(Time.deltaTime * accelator);
    }
}
