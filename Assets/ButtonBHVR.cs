using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBHVR : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ativa()
    {
        canvas.SetActive(true);
    }
    public void Desativa()
    {
        canvas.SetActive(false);
    }
}
