using UnityEngine;


public abstract class Animal: MonoBehaviour {
	public float health;
	public float energy;

	public AnimalData animalData;

	abstract public void Sleep ();
	abstract public void Eat ();

//	[SerializeField]
	private Rigidbody myRigidBody;

	public Rigidbody rigidBody { 
		get { return myRigidBody; } 
	}

	public void Awake(){
		health = animalData.maxHealth;
		energy = animalData.maxEnergy;

		myRigidBody = GetComponent<Rigidbody> ();
	}
}
