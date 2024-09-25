using UnityEngine;
using static UnityEditor.Progress;

public class SpawnItemPoint : MonoBehaviour
{
    [SerializeField] private SpawnItems _spawnItems;
    [SerializeField] private float _timeToSpawn = 3f;

    private float _time = 3f;
    private bool _isSpawning = false;
    private GameObject _item;
    private ItemPickable _itemPickable;

    private void Awake()
    {
        _time = _timeToSpawn;
    }

    private void Update()
    {
        if(_isSpawning == false)
        {
            _itemPickable = _spawnItems.GetRandomItem();
            _item = Instantiate(_itemPickable.gameObject, this.transform);
            _isSpawning = true;
        }

        if(_item == null)
        {
            _time -= Time.deltaTime;
        }

        if (_time < 0 || _isSpawning == false)
        {
            _isSpawning = false;
            _time = _timeToSpawn;
        }
    }

}
