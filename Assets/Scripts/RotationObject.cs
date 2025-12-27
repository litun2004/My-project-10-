using UnityEngine;

public class RotationObjec : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationIncrement;

    private void Update()
    {
        transform.Rotate(_rotationIncrement);
    }
}