using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{
    public AudioSource locksound;
    public GameObject toEnable;
    public Rigidbody rdb;

    public void ButtonAction()
    {
        locksound.Play();

        if (toEnable)
        {
            toEnable.SetActive(true);
        }

        if (rdb)
        {
            rdb.AddForce(Vector3.up*5,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (locksound)
        {
            locksound.Play();
        }
    }

}
