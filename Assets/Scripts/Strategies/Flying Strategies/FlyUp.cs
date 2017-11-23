using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyUp : FlyingStrategy {

	[SerializeField]
	float power = 10f;

	public override void Fly(Animal animal){
		if (animal.energy > 0f) {
//			animal.gameObject.transform.position += Vector3.up * Time.deltaTime;
			animal.rigidBody.AddForce(Vector3.up * power * Time.deltaTime, ForceMode.VelocityChange);
			animal.energy -= 2f * Time.deltaTime;
		}
	}

	public override void SetUpStrategy(GameObject go){

	}

	public override void TearDownStrategy(){

	}
}
