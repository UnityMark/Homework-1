using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [Header("Settings Player")]
    [SerializeField] private protected float _speed = 5f;
    [SerializeField] private protected float _maxSpeed = 15f;
    [SerializeField] private protected float _speedRotation = 900f;
    [SerializeField] private protected int _maxHealth = 150;
    [SerializeField] private protected int _currentHealth = 50;

    [Header("Components")]
    [SerializeField] private protected Movement _movement;
    [SerializeField] private protected CollectorItem _collectorItem;
    [SerializeField] private protected Rigidbody _rigidbody;

    private protected Artifact _artifact;
    private protected List<ParticleSystem> _listParticals = new List<ParticleSystem>();

    public Artifact Artifact => _artifact;
    public int MaxHealth => _maxHealth;
    public int CurrentHealth => _currentHealth;

    public void SetArtifact(Artifact artifact) => _artifact = artifact;

    public void Heal(int value)
    {
        if (value < 0)
        {
            Debug.LogError("Число отрицательное");
            return;
        }

        _currentHealth += value;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }

    public void AddSpeed(float value)
    {
        if (value < 0)
        {
            Debug.LogError("Число отрицательное");
            return;
        }

        _speed += value;

        if(_speed > _maxSpeed)
        {
            _speed = _maxSpeed;
        }
    }

    public void AddPartical(ParticleSystem partical) => _listParticals.Add(partical);

    public bool HasParticale(ParticleSystem partical)
    {
        foreach (var itemPartical in _listParticals)
        {
            if (itemPartical.Equals(partical))
            {
                return true;
            }
        }
        return false;
    }

    private protected abstract void UseArtifact();
}
