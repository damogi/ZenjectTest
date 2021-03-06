﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

public class SpaceShip : MonoBehaviour {

    #region Properties

    [Inject]
    private PlayerInput playerInput;
    [Inject]
    private PlayerAiming playerAiming;

    //Cached components
    [SerializeField]
    private new Rigidbody rigidbody;

    #endregion

    #region Unity functions

    private void FixedUpdate()
    {
        Move();

        if (playerInput.isShooting)
        {
            Shoot();
        }

        Rotate();

        playerAiming.actualPosition = transform.position;
    }

    #endregion

    #region Class functions

    private void Shoot()
    {
        //Shoot()
    }

    private void Move()
    {
        rigidbody.velocity = playerInput.movement;
    }

    private void Rotate()
    {
        Debug.Log("Rotate");
    }

    #endregion

    private IEnumerator ZenjectAutodestruction()
    {
        Debug.Log("Zenject se destruira en...");

        yield return new WaitForSeconds(1f);

        Debug.Log("5");

        yield return new WaitForSeconds(1f);

        Debug.Log("4");

        yield return new WaitForSeconds(1f);

        Debug.Log("3");

        yield return new WaitForSeconds(1f);

        Debug.Log("2");

        yield return new WaitForSeconds(1f);

        Debug.Log("1");

        yield return new WaitForSeconds(1f);

        Debug.Log("KapBoom!");

        while (true)
        {
            Debug.Log("GG");
        }
    }
}
