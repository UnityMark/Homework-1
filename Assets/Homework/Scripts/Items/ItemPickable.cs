using UnityEngine;

public class ItemPickable : MonoBehaviour
{
    [SerializeField] private GameObject _itemPrefab;

    public GameObject ItemPrefab => _itemPrefab;

    private void OnTriggerEnter(Collider other)
    {
        CollectorItem collector = other.GetComponent<CollectorItem>();

        if(collector != null)
        {
            if (collector.CanTake())
            {
                collector.TakeItem(this);
                Destroy(this.gameObject);
            }
            else
            {
                Debug.Log("У вас уже есть предмет!");
            }
        }
    }
}
