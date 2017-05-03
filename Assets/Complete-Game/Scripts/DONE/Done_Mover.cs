using UnityEngine;
using System.Collections;
using Zenject;

public class Done_Mover : IInitializable
{
	#region Properties

	public float speed;
	private Rigidbody myBody;
	private Transform transform;

	#endregion

	#region Zenject functions

	public void Initialize()
	{
		myBody.velocity = transform.forward * speed;
	}

	#endregion
}
