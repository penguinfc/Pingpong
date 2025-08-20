using UnityEngine;

public class BallController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float Speed = 2f;        // скорость движения вправо
    public float MaxDistance = 5f;  // дистанция до сброса

    private Vector3 _startPosition;
    private float _traveled;

    private void Start()
    {
        _startPosition = transform.position;
        _traveled = 0f;
    }

    private void Update()
    {
        // движение вправо
        Vector3 delta = Vector3.right * Speed * Time.deltaTime;
        transform.Translate(delta, Space.World);

        // считаем пройденное расстояние
        _traveled += delta.magnitude;

        // Обнуление 
        if (_traveled >= MaxDistance)
        {
            transform.position = _startPosition;
            _traveled = 0f;
        }
    }
}
