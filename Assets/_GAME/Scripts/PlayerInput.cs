using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Zenject;

public class PlayerInput: IFixedTickable
{
    #region Properties

    public float speed = 10f;

    //Movement
    public float horizontalMovement;
    public float verticalMovement;

    public Vector3 movement;

    //Shooting bool
    public bool isShooting;

    #endregion

    #region Zenject functions

    public void FixedTick()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        movement = new Vector3(horizontalMovement, verticalMovement, 0f) * speed;

        isShooting = Input.GetKeyDown(KeyCode.Space);
    }

    #endregion
}
