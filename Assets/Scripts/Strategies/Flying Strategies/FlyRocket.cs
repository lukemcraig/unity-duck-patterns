using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class FlyRocket : FlyingStrategy {

	private Fuel fuel;
	private Rigidbody rigidBody;
	private FixedJoint fixedJoint;
	private IFlyable ifly;

	void Awake(){
		fuel = gameObject.GetComponent<Fuel> ();
		rigidBody = gameObject.GetComponent<Rigidbody> ();
	}

	public override void Fly(Animal animal){	
		if (fuel.fuelLevel > 0f) {	
			fuel.fuelLevel -= 10f * Time.deltaTime;
			rigidBody.AddForce (Vector3.forward * 2f, ForceMode.VelocityChange);
		} else {
			ifly.flyingStrategy = new FlyNone();
			ifly = null;
		}
	}

	public override void SetUpStrategy(GameObject go){
		fixedJoint = gameObject.AddComponent<FixedJoint> ();
		fixedJoint.connectedBody = go.GetComponent<Rigidbody>();
		ifly = go.GetComponent<IFlyable> ();
	}

	public override void TearDownStrategy(){
		fixedJoint.connectedBody = null;
		Destroy (fixedJoint);
		gameObject.AddComponent<UnnattachedRocket> ();

	}
}
