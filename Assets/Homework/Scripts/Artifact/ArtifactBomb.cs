using UnityEngine;

public class ArtifactBomb : Artifact
{
    [SerializeField] private float _speed;
    private bool _isStart = false;
    private Vector3 direction;

    private void Update()
    {
        if (_isStart)
        {
            transform.Translate(direction * _speed * Time.deltaTime, Space.World);
        }
    }

    public override void UseArtifact(Character character)
    {
        this.transform.SetParent(null);
        _isStart = true;
        direction = character.transform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (_isStart && player == null)
        {
            _effectItem = Instantiate(_effectItem.gameObject, this.gameObject.transform.position, Quaternion.EulerRotation(Vector3.zero)).GetComponent<ParticleSystem>();
            _effectItem.Play();
            Destroy(this.gameObject);
        }
    }
}
