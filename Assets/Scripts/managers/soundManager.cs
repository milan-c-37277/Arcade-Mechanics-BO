using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Weapon;

public class soundManager : MonoBehaviour
{
    public static soundManager Instance { get; set; }

    public AudioSource shootingChannel;

    public AudioSource emptyMagazineSoundPistol;

    public AudioClip rifleShot;
    public AudioClip pistolShot;

    public AudioSource reloadSoundPistol;
    public AudioSource reloadSoundRifle;

    public AudioSource playerChannel;
    public AudioClip playerHurt;
    public AudioClip playerDie;

    public AudioClip gameOverMusic;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayShootingSound(WeaponModel weapon)
    {
        switch(weapon)
        {
            case WeaponModel.Pistol:
                shootingChannel.PlayOneShot(pistolShot);
                break;
            case WeaponModel.Rifle:
                shootingChannel.PlayOneShot(rifleShot);
                break;
        }
    }
    public void PlayreloadSound(WeaponModel weapon)
    {
        switch (weapon)
        {
            case WeaponModel.Pistol:
                shootingChannel.Play();
                break;
            case WeaponModel.Rifle:
                reloadSoundRifle.Play();
                break;
        }
    }
}
