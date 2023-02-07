using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	HingeJoint[] joints;
	
    // Start is called before the first frame update
    void Start()
    {
         joints = GetComponentsInChildren<HingeJoint>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
		{
			foreach(HingeJoint joint in joints)
			{
				JointMotor motor = joint.motor;
				motor.targetVelocity += 50 * Time.deltaTime;
				joint.motor = motor;
			}
		}
		
		if(Input.GetKey(KeyCode.S))
		{
			foreach(HingeJoint joint in joints)
			{
				JointMotor motor = joint.motor;
				motor.targetVelocity -= 50 * Time.deltaTime;
				joint.motor = motor;
			}
		}
    }
}
