using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_direction.normalized * (_speed * Time.deltaTime));
    }
}
