using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerAiming: IInitializable, ITickable{

    #region Properties

    public Vector3 actualPosition;

    //Aiming settings
    public float lookAngle;

    public Vector3 mousePosition;
    public Vector2 mouseDirection;

    #endregion

    #region Zenject functions

    public void Initialize()
    {
        actualPosition = Vector3.zero;
    }

    public void Tick()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseDirection = (mousePosition - actualPosition).normalized;

        lookAngle = Vector2.Angle(Vector3.up, mouseDirection);
    }

    #endregion
}
