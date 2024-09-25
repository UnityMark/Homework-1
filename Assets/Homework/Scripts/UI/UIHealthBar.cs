using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _slider.maxValue = _character.MaxHealth;
    }

    private void Update()
    {
        ChangedValue();
    }

    private void ChangedValue() => _slider.value = _character.CurrentHealth;
}
