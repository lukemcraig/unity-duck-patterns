using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class UnnattachedRocket : MonoBehaviour {

	void OnCollisionEnter(Collision collsion){
		IFlyable ifly = collsion.collider.GetComponent<IFlyable>();
		if (ifly != null) {		
			ifly.flyingStrategy = gameObject.GetComponent<FlyRocket>();
			Destroy (this);
		}
	}
}
