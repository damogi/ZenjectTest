using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

[System.Serializable]
public class Boundaries 
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : ITickable, IFixedTickable
{
    #region Properties

    private float nextFire;
    private DiContainer diContainer; //TODO: Pool

    //Settings
    readonly PlayerControllerSettings playerControllerSettings;

	#endregion

	#region Zenject functions

	public void Tick()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + playerControllerSettings.fireRate;
			diContainer.InstantiatePrefab(playerControllerSettings.shot);
            playerControllerSettings.audioSource.Play ();
		}
	}

	public void FixedTick()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        playerControllerSettings.rigidbody.velocity = movement * playerControllerSettings.speed;

        playerControllerSettings.rigidbody.position = new Vector3
		(
			Mathf.Clamp (playerControllerSettings.rigidbody.position.x, playerControllerSettings.boundaries.xMin, playerControllerSettings.boundaries.xMax), 
			0.0f, 
			Mathf.Clamp (playerControllerSettings.rigidbody.position.z, playerControllerSettings.boundaries.zMin, playerControllerSettings.boundaries.zMax)
		);

        playerControllerSettings.rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, playerControllerSettings.rigidbody.velocity.x * -playerControllerSettings.tilt);
	}

	#endregion
}

[System.Serializable]
public class PlayerControllerSettings
{
    public float speed;
    public float fireRate;
    public float tilt;

    public AudioSource audioSource;
    public GameObject shot;
    public Transform shotSpawn;
    public Rigidbody rigidbody;

    public Boundaries boundaries;
}
