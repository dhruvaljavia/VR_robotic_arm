using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLength: MonoBehaviour
{
    
    private GameObject Arm2;
    HingeJoint hinge;
    JointMotor motor;
    public float a3;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        motor = hinge.motor;
        motor.force = 10;
        motor.targetVelocity = -30;
        motor.freeSpin = false;
        hinge.useMotor = true;
        Arm2 = GameObject.Find("Arm2");
        a3 = 90;
    }

    // Update is called once per frame
    void Update()
    {
        if (Arm2.transform.localEulerAngles.x >= (a3-1.5) && Arm2.transform.localEulerAngles.x <= a3)
        {
            hinge.useMotor = false;
            
            
        }
        if (Arm2.transform.localEulerAngles.x > a3)
        {
            hinge.useMotor = true;
            motor.targetVelocity = 30;
        }
        if (Arm2.transform.localEulerAngles.x < (a3-1.5))
        {
            hinge.useMotor = true;
            motor.targetVelocity = -30;
        }
        //Debug.Log(Arm2.transform.localEulerAngles.x);
    }
}
