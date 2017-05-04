using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class WaveSpawner: IInitializable, ITickable
{
    #region Properties

    private bool isSpawningAsteroid;

    readonly Asteroid.Pool asteroidPool;
    readonly Bullet.Pool bulletPool;

    private float timeToSpawnAsteroid;

    //Coroutines
    private IEnumerator spawnAsteroid;

    #endregion

    #region Zenject functions

    public void Initialize()
    {
        isSpawningAsteroid = false;
    }

    public void Tick()
    {
        switch (isSpawningAsteroid)
        {
            case true:
                SpawnAsteroid();
                break;

            case false:
                break;
        }
    }

    #endregion

    #region Class functions

    private void SpawnAsteroid()
    {
        spawnAsteroid = SpawningAsteroid();
    }

    #endregion

    #region Coroutines

    private IEnumerator SpawningAsteroid()
    {
        yield return new WaitForSeconds(timeToSpawnAsteroid);

        asteroidPool.Spawn();
    }

    #endregion
}
