using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemSpin : MonoBehaviour, IDragHandler
{
    [SerializeField]
    private Transform itemPrefab;

    [SerializeField] private DummyInventory dummyInventory;
    // Start is called before the first frame update
    private void Start() {

        dummyInventory.OnItemSelected += DummyInventory_OnItemSelected;
    }

    private void DummyInventory_OnItemSelected(object sender, ItemSO itemSO)
    {
        if (itemPrefab != null)
        {
            Destroy(itemPrefab.gameObject);
        }
        itemPrefab = Instantiate(itemSO.prefab, new Vector3(1000, 1000, 1000), Quaternion.identity);
    }

    public void OnDrag(PointerEventData eventData)
    {
        itemPrefab.eulerAngles += new Vector3(-eventData.delta.y, -eventData.delta.x);
    }
}
