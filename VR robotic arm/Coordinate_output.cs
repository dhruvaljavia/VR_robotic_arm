using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Coordinate_output : MonoBehaviour
{
	private GameObject armRotar2;
	public Vector3 pos;
	SerialPort sp = new SerialPort("COM7", 9600);
    // Start is called before the first frame update
    void Start()
    {
        armRotar2 = GameObject.Find("armRotar2");
        sp.Open();
        sp.ReadTimeout = 200;
    }

    // Update is called once per frame
    void Update()
    {
        pos = armRotar2.transform.position;
        float a = ((float)(pos.x * 1000.0) - (float)(126.0))/((float)(2371.0))* ((float)(26.7));
        float b = (float)(pos.y * 100.0)/((float)(276.0))*((float)(26.7)) ;
        float c = ((float)(pos.z * 1000.0) - (float)(431.0))/((float)(2371.0)) * ((float)(26.7));
        string x = (a).ToString();
        string y = (b).ToString();
        string z = (c).ToString();
        //string y = pos.y.ToString();
        //string z = pos.z.ToString();
        //string p = x + " " + y + " " + z;
        sp.WriteLine(x);
        sp.WriteLine(y);
        sp.WriteLine(z);
        Debug.Log(y);
    }
}
