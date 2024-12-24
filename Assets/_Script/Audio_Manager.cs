using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    public AudioSource aus;
    public AudioClip au_click;
    public AudioClip au_point;
    public AudioClip au_hit;
    public AudioClip au_die;


    public void Sound_Click()
    {
        aus.PlayOneShot(au_click);
    }
    public void Sound_Point()
    {
        aus.PlayOneShot(au_point);
    }
    public void Sound_Hit()
    {
        aus.PlayOneShot(au_hit);
    }
    public void Sound_Die()
    {
        aus.PlayOneShot(au_die);
    }
}
