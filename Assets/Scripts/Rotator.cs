using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
