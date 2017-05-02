using UnityEngine;
using System.Collections;
using Zenject;

public class Done_RandomRotator : IInitializable
{
	public float tumble;

	private Rigidbody myBody;

	public void Initialize()
	{
		myBody.angularVelocity = Random.insideUnitSphere * tumble;
	}
}