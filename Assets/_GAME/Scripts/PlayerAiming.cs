using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerAiming: IInitializable, ITickable{

    #region Properties

    public Vector3 actualPosition;

    //Raycast settings
    private Ray ray;
    private RaycastHit hit;

    public Vector3 targetPosition;

    #endregion

    #region Zenject functions

    public void Initialize()
    {
        targetPosition = Vector3.zero;
        actualPosition = Vector3.zero;
    }

    public void Tick()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 50f))
        {
            targetPosition = hit.point;
        }

        Vector3 targetDirection = targetPosition - actualPosition;

        targetDirection.y = 0;
    }

    #endregion
}
