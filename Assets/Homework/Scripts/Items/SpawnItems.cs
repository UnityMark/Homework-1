using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    [SerializeField] private List<ItemPickable> _listItems = new List<ItemPickable>();

    public ItemPickable GetRandomItem() => _listItems[Random.Range(0, _listItems.Count)];
}
