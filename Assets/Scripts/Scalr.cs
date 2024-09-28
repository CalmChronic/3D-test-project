using UnityEngine;

public class Scalr : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += _scaleSpeed * Time.deltaTime * Vector3.one;
    }
}
