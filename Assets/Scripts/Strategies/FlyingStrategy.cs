using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FlyingStrategy: Strategy{

	public abstract void Fly(Animal animal);

	public override abstract void SetUpStrategy (GameObject go);

	public override abstract void TearDownStrategy();
}
