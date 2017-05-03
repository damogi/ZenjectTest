using UnityEngine;
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
    }

    #endregion

    #region Class functions

    private void Shoot()
    {
        Debug.Log("Shoot");
    }

    private void Move()
    {
        rigidbody.velocity = playerInput.movement;
    }

    private void Rotate()
    {
        playerAiming.actualPosition = transform.position;

        transform.LookAt(playerAiming.actualPosition + playerAiming.targetPosition, Vector3.up);
    }

    #endregion
}
