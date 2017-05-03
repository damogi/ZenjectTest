using UnityEngine;
using System.Collections;
using Zenject;

public class BGScroller: IInitializable, ITickable
{
    #region Properties

    private Vector3 startPosition;

    private Transform transform;

    //Settings
    readonly BGScrollerSettings bgsScrollerSettings;

    #endregion

    #region Zenject functions

    public void Initialize()
    {
        startPosition = transform.position;
    }

    public void Tick()
    {
        float newPosition = Mathf.Repeat(Time.time * bgsScrollerSettings.scrollSpeed, -bgsScrollerSettings.tileSizeZ);

        transform.position = startPosition + Vector3.forward * newPosition;
    }

    #endregion
}

[System.Serializable]
public class BGScrollerSettings
{
	public float scrollSpeed;
	public float tileSizeZ;
}
