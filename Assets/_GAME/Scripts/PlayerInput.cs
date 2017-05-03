using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Zenject;

public class PlayerInput: IFixedTickable
{
    #region Properties

    //Movement
    public float speed;

    public float horizontalMovement;
    public float verticalMovement;

    public Vector3 movement;

    //Shooting bool
    public bool isShooting;

    #endregion

    #region Zenject functions

    public PlayerInput(float speed)
    {
        this.speed = speed;
    }

    public void FixedTick()
    {
        horizontalMovement = Input.GetAxis("Horizotal");
        verticalMovement = Input.GetAxis("Vertical");

        movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);

        isShooting = Input.GetKeyDown(KeyCode.Space);
    }

    #endregion
}
