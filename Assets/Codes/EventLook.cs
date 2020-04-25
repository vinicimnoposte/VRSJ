using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLook : MonoBehaviour
{
    public AudioSource locksound;
    public GameObject toEnable;
    public Rigidbody rdb;
    public Vector3 force;
    public void ButtonAction()
    {
        locksound.Play();

        if (toEnable)
        {
            toEnable.SetActive(true);
        }

        if (rdb)
        {
            rdb.AddForce(force,ForceMode.Impulse);
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
