using UnityEngine;

public class SelfAxisMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(transform.forward * _speed*Time.deltaTime, Space.World);
    }
}
