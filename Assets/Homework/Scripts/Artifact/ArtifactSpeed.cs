using UnityEngine;

public class ArtifactSpeed : Artifact
{
    [SerializeField] private float _speedEffect;

    public override void UseArtifact(Character character)
    {
        if (character.HasParticale(_effectItem) == false)
        {
            Transform parent = this.gameObject.transform.parent;
            ParticleSystem particle = Instantiate(_effectItem.gameObject, parent.transform.parent).GetComponent<ParticleSystem>();
            particle.transform.position = particle.transform.position + _offsetEffectPosition;
            character.AddPartical(_effectItem);
        }

        character.AddSpeed(_speedEffect);
        Destroy(this.gameObject);
    }
}
