using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item3DViewer : MonoBehaviour, IDragHandler {
    
    [SerializeField] private DummyInventory dummyInventory;
    [SerializeField]
    private Transform itemPrefab;

    public GameObject item1;
    public GameObject item2;

    private void Start() {
        dummyInventory.OnItemSelected += DummyInventory_OnItemSelected;
    }
    
    
    public void OnDrag(PointerEventData eventData)
    {
        itemPrefab.eulerAngles += new Vector3(-eventData.delta.y, -eventData.delta.x);
        
    }
    private void DummyInventory_OnItemSelected(object sender, ItemSO itemSO) {
       // if (itemPrefab != null) {
       //     DestroyImmediate(itemPrefab.gameObject, true);
       // }
        itemPrefab = Instantiate(itemSO.prefab, new Vector3(1000, 1000, 1002), Quaternion.identity);
    }

    

    
    public void ClickSpawn1()
    {
        if (itemPrefab != null)
        {
            itemPrefab.gameObject.SetActive(false);
        }
        itemPrefab = Instantiate(item1.transform, new Vector3(1, 0, 11), Quaternion.identity);
    }
    public void ClickSpawn2()
    {
        if (itemPrefab != null)
        {
            itemPrefab.gameObject.SetActive(false);
        }
        itemPrefab = Instantiate(item2.transform, new Vector3(1, 1, 11), Quaternion.identity);
    }
}