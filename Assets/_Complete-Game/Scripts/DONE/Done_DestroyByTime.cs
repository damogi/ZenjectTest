using UnityEngine;
using System.Collections;
using Zenject;

public class Done_DestroyByTime : IInitializable
{
	public float lifetime;

	public void Initialize()
	{
		Destro (gameObject, lifetime);
	}
}
