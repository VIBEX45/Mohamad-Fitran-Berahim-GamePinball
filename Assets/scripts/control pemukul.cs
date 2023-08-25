using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlpemukul : MonoBehaviour
{
	public KeyCode input;

	private float targetpress;
	private float targetrelease;

	private HingeJoint hinge;

    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

	targetpress = hinge.limits.max;
	targetrelease = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        control();
    }

    private void control(){
	JointSpring power = hinge.spring;
	
	if (Input.GetKey(input)){
		power.targetPosition = targetpress;
	}
	else{
		power.targetPosition = targetrelease;
	}
	
	hinge.spring = power;
}
}
