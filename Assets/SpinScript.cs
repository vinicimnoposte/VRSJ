using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpinScript : MonoBehaviour
{
    private Transform itemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDrag(PointerEventData eventData)
    {
        itemPrefab.eulerAngles += new Vector3(-eventData.delta.y, -eventData.delta.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
