using UnityEngine;

public class ArtifactHealth : Artifact
{
    [SerializeField] private int _healthEffect = 10;
    private bool _isStart = false;

    private void Update()
    {
        if(_isStart == true && _effectItem.isPlaying == false)
        {
            Destroy(this.gameObject);
        }
    }

    public override void UseArtifact(Character character)
    {
        _effectItem = Instantiate(_effectItem.gameObject, this.gameObject.transform).GetComponent<ParticleSystem>();
        _effectItem.transform.position = _effectItem.transform.position + _offsetEffectPosition;
        _isStart = true;
        character.Heal(_healthEffect);
    }
}
