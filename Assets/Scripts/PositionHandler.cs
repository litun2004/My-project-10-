using UnityEngine;

public class PositionHandler : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleIncrement;
    [SerializeField] private float _speedMultiplier;

    private void Update()
    {
        transform.localScale += _scaleIncrement *_speedMultiplier * Time.deltaTime;
    }
}