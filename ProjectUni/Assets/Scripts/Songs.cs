using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Songs : MonoBehaviour
{
    public AudioSource sound;

    public void ActiveSound(){

        sound.Play();

    }
}
