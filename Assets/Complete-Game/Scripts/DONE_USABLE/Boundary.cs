using UnityEngine;

public class Boundary : MonoBehaviour
{
    #region Unity functions

    void OnTriggerExit(Collider other)
    {
        DestroyImmediate(other.gameObject);
    }

    #endregion
}
