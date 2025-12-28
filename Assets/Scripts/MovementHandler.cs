using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _movementIncrement;
    [SerializeField] private Transform _rotationCenter;

    private void Update()
    {        
        transform.RotateAround(_rotationCenter.position, Vector3.up, _movementIncrement.y * Time.deltaTime);
    }
}