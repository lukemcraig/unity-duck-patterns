using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFlyable {
	FlyingStrategy flyingStrategy { get; set; }
	void Fly();

}
