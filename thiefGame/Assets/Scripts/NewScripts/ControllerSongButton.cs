using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSongButton : MonoBehaviour
{
    [SerializeField] private AudioSource ClickSong;
    [SerializeField] private AudioSource BuySong;
    [SerializeField] private AudioSource NoMoneySong;



    public void ClickSongButton()
    {
        ClickSong.Play();
    }

    public void BuySongButton()
    {
        BuySong.Play();
    }

    public void NoMoneySongButton()
    {
        NoMoneySong.Play();
    }
}
