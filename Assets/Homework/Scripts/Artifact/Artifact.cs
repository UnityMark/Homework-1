using UnityEngine;

public abstract class Artifact : MonoBehaviour
{
    [SerializeField] private protected ParticleSystem _effectItem;
    [SerializeField] private protected Vector3 _offsetEffectPosition;

    public abstract void UseArtifact(Character character);
}
