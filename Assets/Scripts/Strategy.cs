using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Strategy : MonoBehaviour {

	public abstract void SetUpStrategy (GameObject go);

	public abstract void TearDownStrategy();

}
