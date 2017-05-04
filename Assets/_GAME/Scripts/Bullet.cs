using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Bullet : MonoBehaviour
{
    public class Pool : MemoryPool<Bullet>
    {
        protected override void OnCreated(Bullet item)
        {
            // Called immediately after the item is first added to the pool
        }

        protected override void OnSpawned(Bullet item)
        {
            // Called immediately after the item is removed from the pool
        }

        protected override void OnDespawned(Bullet item)
        {
            // Called immediately after the item is returned to the pool
        }

        protected override void Reinitialize(Bullet foo)
        {
            // Similar to OnSpawned
            // Called immediately after the item is removed from the pool
            // This method will also contain any parameters that are passed along
            // to the memory pool from the spawning code
        }
    }
}
