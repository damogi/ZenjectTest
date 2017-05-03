using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

public class Done_WeaponController : IInitializable
{
	#region Properties
	
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	private AudioSource audioSource;

	private DiContainer diContainer;

	#endregion

	#region Zenject functions
	public void Initialize()
	{
		//InvokeRepeating ("Fire", delay, fireRate);
	}

	#endregion

	#region Class functions

	void Fire ()
	{
		diContainer.InstantiatePrefab(shot); //TODO: PoolManager
		audioSource.Play();
	}

	#endregion
}
