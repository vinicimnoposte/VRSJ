using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class InspectItem : MonoBehaviour
{
    [SerializeField]
    private Transform itemPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObject()
    {
        Transform item = Instantiate(itemPrefab, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 2), Quaternion.identity);
        item.transform.parent = GameObject.Find("CamInv").transform;
        
        Debug.Log("spawnei!");

    }
    
    
}
