﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Bullet : MonoBehaviour
{
    public class Pool : MemoryPool<Bullet>
    {
        //Bullet Pool
    }
}
