using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float x,y,z;
    private float Th, Ph, R;
    // Start is called before the first frame update
    void Start()
    {
        x = 0.0001f;
        y = -1f;
        z = 0.0001f;
        Th = - Mathf.Rad2Deg * (Mathf.Atan(y / x));
        Ph = Mathf.Rad2Deg * (Mathf.Atan(x / (z * Mathf.Cos(Mathf.Atan(y / x)))));
        R = z / Mathf.Cos((Mathf.Atan(x / (z * Mathf.Cos(Mathf.Atan(y / x))))));
        Debug.Log(Th);
        Debug.Log(Ph);
        Debug.Log(R);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
