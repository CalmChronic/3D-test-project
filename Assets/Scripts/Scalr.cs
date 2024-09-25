using UnityEngine;

public class Scalr : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);
    }
}
