using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

public class SpaceShip : MonoBehaviour {

    #region Properties

    [Inject]
    private PlayerInput playerInput;

    //Cached components
    private new Rigidbody rigidbody;

    #endregion

    #region Unity functions

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (playerInput.isShooting)
        {
            Shoot();
        }

        rigidbody.velocity = playerInput.movement;
    }

    #endregion

    #region Class functions

    private void Shoot()
    {
        Debug.Log("Shoot");
    }

    #endregion
}
