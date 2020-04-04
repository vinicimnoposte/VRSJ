using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Transform doorMesh;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Abre());
    }

   
    public IEnumerator Abre()
    {
        while (doorMesh.transform.rotation.eulerAngles.y != -150)
        {
            doorMesh.transform.rotation = Quaternion.Lerp(doorMesh.transform.rotation, Quaternion.Euler(0,-150,0), Time.deltaTime);

            yield return new WaitForEndOfFrame();

        }
    }

    public IEnumerator Fecha()
    {
        while (doorMesh.transform.rotation.eulerAngles.y != 0)
        {
            doorMesh.transform.rotation = Quaternion.Lerp(doorMesh.transform.rotation, Quaternion.identity, Time.deltaTime);

            yield return new WaitForEndOfFrame();

        }



    }

}
