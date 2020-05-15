using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotBase : MonoBehaviour
{
    private GameObject Base;
    HingeJoint hinge;
    JointMotor motor;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        motor = hinge.motor;
        motor.force = 10;
        motor.targetVelocity = 10;
        motor.freeSpin = false;
        hinge.useMotor = false;
        Base = GameObject.Find("Base");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            hinge.useMotor = true;
            motor.force = 1000;
            motor.targetVelocity = -50;
            hinge.motor = motor;
            

        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            hinge.useMotor = true;
            motor.force = 1000;
            motor.targetVelocity = 50;
            hinge.motor = motor;
            
        }
        else
        {
            hinge.useMotor = false;
        }
    }
}
