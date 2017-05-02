using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

[System.Serializable]
public class Done_Boundary 
{
	public float xMin, xMax, zMin, zMax;
}

public class Done_PlayerController : ITickable, IFixedTickable
{
	#region Properties

	public float speed;
	public float tilt;
	public Done_Boundary boundary;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public Rigidbody myBody;
	public AudioSource audioSource;
	private float nextFire;
	private DiContainer diContainer;

	#endregion

	#region Zenject functions

	public void Tick()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			diContainer.InstantiatePrefab(shot);
			audioSource.Play ();
		}
	}

	public void FixedTick()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		myBody.velocity = movement * speed;
		
		myBody.position = new Vector3
		(
			Mathf.Clamp (myBody.position.x, boundary.xMin, boundary.xMax), 
			0.0f, 
			Mathf.Clamp (myBody.position.z, boundary.zMin, boundary.zMax)
		);
		
		myBody.rotation = Quaternion.Euler (0.0f, 0.0f, myBody.velocity.x * -tilt);
	}

	#endregion
}
