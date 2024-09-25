using UnityEngine;

public class CollectorItem : MonoBehaviour
{
    [SerializeField] private Transform _attachSpine;
    [SerializeField] private Character _character;

    public void TakeItem(ItemPickable item)
    {
        GameObject prefab = Instantiate(item.ItemPrefab, _attachSpine);
        _character.SetArtifact(prefab.GetComponent<Artifact>());
    }

    public bool CanTake() => _character.Artifact == null;
}
