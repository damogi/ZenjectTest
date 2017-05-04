using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Asteroid : MonoBehaviour
{
    public class Pool : MemoryPool<Asteroid>
    {
        //Asteroid Pool
    }
}
