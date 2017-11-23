using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bird : Animal, IFlyable
{
	[SerializeField]
	private FlyingStrategy myFlyingStrategy;

	public FlyingStrategy flyingStrategy { 
		get { 
			return myFlyingStrategy; 
		} 
		set { 
			myFlyingStrategy.TearDownStrategy ();
			myFlyingStrategy = value;
			myFlyingStrategy.SetUpStrategy (gameObject);
		} 
	}

	public void Fly ()
	{
		myFlyingStrategy.Fly (this);
	}

	void Update ()
	{
		Fly ();
	}
}
