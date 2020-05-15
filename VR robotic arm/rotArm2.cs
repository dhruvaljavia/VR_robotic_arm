using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotArm2 : MonoBehaviour
{
    private GameObject Arm2;
    HingeJoint hinge;
    JointMotor motor;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        rb = GetComponent<Rigidbody>();
        motor = hinge.motor;
        motor.force = 10;
        motor.targetVelocity = 10;
        motor.freeSpin = false;
        hinge.useMotor = false;
        Arm2 = GameObject.Find("Arm2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.constraints = RigidbodyConstraints.None;
            hinge.useMotor = true;
            motor.force = 1000;
            motor.targetVelocity = -50;
            hinge.motor = motor;


        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.constraints = RigidbodyConstraints.None;
            hinge.useMotor = true;
            motor.force = 1000;
            motor.targetVelocity = 50;
            hinge.motor = motor;

        }
        else
        {
            hinge.useMotor = false;
            rb.constraints = RigidbodyConstraints.FreezeRotationX;
        }
    }
}