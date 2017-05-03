using UnityEngine;
using System.Collections;
using Zenject;

public class Done_RandomRotator : IInitializable
{
	#region Properties

	public float tumble;

	private Rigidbody myBody;

	#endregion

	#region Zenject functions

	public void Initialize()
	{
		myBody.angularVelocity = Random.insideUnitSphere * tumble;
	}

	#endregion
}