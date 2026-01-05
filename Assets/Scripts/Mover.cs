using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementIncrement;
    [SerializeField] private Transform _rotationCenter;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
        transform.RotateAround(_rotationCenter.position, Vector3.up, _movementIncrement.y * Time.deltaTime);
    }
}