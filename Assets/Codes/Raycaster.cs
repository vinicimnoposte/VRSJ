using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycaster : MonoBehaviour
{
    public TextMesh textDebug;
    public GameObject crosshair;
    float counter=2;
    public FPSWalk fpswalk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects 
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 6))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            //Debug.Log("Did Hit");
            textDebug.text = hit.transform.name;
            crosshair.transform.position = hit.point;
            //crosshair.transform.forward = hit.normal;
            crosshair.transform.forward = transform.forward;
            if (hit.transform.gameObject.CompareTag("Player"))
            {
                crosshair.GetComponent<Image>().CrossFadeColor(Color.green, .5f, false, false);
                counter -= Time.deltaTime;
                if (counter < 0)
                {
                    hit.transform.gameObject.SendMessageUpwards("ButtonAction");
                    counter = 3;
                }
            }
            else if(hit.transform.gameObject.CompareTag("Walkable"))
            {
                crosshair.GetComponent<Image>().CrossFadeColor(Color.blue, .5f, false, false);
                counter -= Time.deltaTime;
                if (counter < 0)
                {
                    fpswalk.positionToGo = hit.transform.position;
                }
            }
            else
            {
                counter = 3;
                crosshair.GetComponent<Image>().CrossFadeColor(Color.red, .5f, false, false);
            }
        }
        else
        {
            crosshair.GetComponent<Image>().CrossFadeColor(Color.black, .0f, false, false);
        }

       
    }
}
