using UnityEngine;
using System.Collections;
using Zenject;

public class Done_Mover : IInitializable
{
	public float speed;

	private Rigidbody myBody;

	private Transform transform;

	public void Initialize()
	{
		myBody.velocity = transform.forward * speed;
	}
}
