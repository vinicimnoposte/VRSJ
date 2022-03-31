using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro2 : MonoBehaviour
{
    private bool gyroEnabled;
    private UnityEngine.Gyroscope gyro;

    private GameObject cameraContainer;
    public GameObject fpscontroller;
    
    private Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        
        cameraContainer = new GameObject("Camera Container");

        fpscontroller.transform.position = transform.position;
        transform.SetParent(fpscontroller.transform);

        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            fpscontroller.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }
}
