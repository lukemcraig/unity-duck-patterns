using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyForward : FlyingStrategy {

	[SerializeField]
	float power = 5f;

	public override void Fly(Animal animal){
		if (animal.energy > 0f) {
			//flyer.gameObject.transform.position += (Vector3.up + Vector3.forward) * Time.deltaTime;
			animal.rigidBody.AddForce((Vector3.up + Vector3.forward) * power * Time.deltaTime, ForceMode.VelocityChange);
			animal.energy -= .5f * Time.deltaTime;
		}
	}

	public override void SetUpStrategy(GameObject go){

	}

	public override void TearDownStrategy(){

	}
}
