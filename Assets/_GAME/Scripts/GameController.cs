using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour {

    [Inject]
    public WaveSpawner waveSpawner;

    #region Unity functions

    private void Start()
    {
        Debug.Log(waveSpawner);
    }

    #endregion
}
