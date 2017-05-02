using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

public class Done_WeaponController : IInitializable
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	private AudioSource audioSource;

	private DiContainer diContainer;

	public void Initialize()
	{
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire ()
	{
		diContainer.InstantiatePrefab(shot); //TODO: PoolManager
		audioSource.Play();
	}
}
