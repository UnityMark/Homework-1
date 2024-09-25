using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] private float _weak;
    
    private Vector3 _defaultPosition;
    private float _time;

    private void Awake()
    {
        _defaultPosition = this.transform.position;
    }

    private void Update()
    {
        _time += Time.deltaTime;
        transform.position = _defaultPosition + Vector3.up * Mathf.Sin(_time) / _weak;
    }
}
