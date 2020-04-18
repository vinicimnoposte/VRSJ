using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Transform doorMesh;
    bool closed=true;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Abre());
    }

   
    public IEnumerator Abre()
    {
        float ang=0;
        while (ang>-148)
        {
            ang = Mathf.Lerp(ang, -150,Time.deltaTime);
            doorMesh.transform.rotation = Quaternion.Euler(0, ang, 0);
          
            yield return new WaitForEndOfFrame();

        }
        closed = false;
    }

    public IEnumerator Fecha()
    {
        float ang = -150;
        while (ang<0)
        {
            ang = Mathf.Lerp(ang, 1, Time.deltaTime);
            doorMesh.transform.rotation = Quaternion.Euler(0, ang, 0);

            yield return new WaitForEndOfFrame();

        }

        closed = true;

    }

    public void ButtonAction()
    {
        if (closed)
        {
            StartCoroutine(Abre());

        }
        else
        {
            StartCoroutine(Fecha());
        }
    }

}
