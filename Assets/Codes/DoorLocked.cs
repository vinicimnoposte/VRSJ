using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{
    public AudioSource locksound;
    
   

    public void ButtonAction()
    {
        locksound.Play();
    }

}
