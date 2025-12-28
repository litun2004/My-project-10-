using UnityEngine;

public class RotationPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationIncrement;

    private void Update()
    {
        transform.Rotate(_rotationIncrement);
    }
}