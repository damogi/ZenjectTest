using UnityEngine;
using System.Collections;
using Zenject;

public class Done_BGScroller: IInitializable, ITickable
{
	private Vector3 startPosition;

	private Transform transform;

	readonly BGScrollerSettings bgsScrollerSettings;
	
	public void Initialize()
	{
		startPosition = transform.position;
	}

	public void Tick()
	{
		float newPosition = Mathf.Repeat(Time.time * bgsScrollerSettings.scrollSpeed, -bgsScrollerSettings.tileSizeZ);
		transform.position = startPosition + Vector3.forward * newPosition;
	}
}

public class BGScrollerSettings
{
	public float scrollSpeed;
	public float tileSizeZ;
}