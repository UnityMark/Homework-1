using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        this.transform.Rotate(Vector3.up * _speed, Space.World);
    }
}
