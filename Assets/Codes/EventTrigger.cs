using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{

    public AudioSource sound;
    public GameObject toEnable;
    public Rigidbody rdb;
    public bool autodestroy=false;

    public Vector3 force;

    private void OnTriggerEnter(Collider other)
    {
        sound.Play();

        if (toEnable)
        {
            toEnable.SetActive(true);
        }

        if (rdb)
        {
            rdb.AddForce(force * 5, ForceMode.Impulse);
        }

        if (autodestroy)
        {
            Destroy(gameObject,5);
        }
    }

}
