using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;
    public static AudioManager Instance => _instance;

    [Header("AudioSources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource SFXSource2;

    [Header("Musics")]
    public AudioClip music;
    [Header("SFX")]
    public AudioClip dashSound;
    public AudioClip impactSound;
    public AudioClip buttonClickSound;
    public AudioClip leverSound;
    public AudioClip bumperSound;
    public AudioClip deathSound;
    public AudioClip winSound;
    public AudioClip startSound;
    public AudioClip corpseSound;


    private void Awake()
    {
        // Singleton
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            _instance = this;
            this.transform.SetParent(null);
        }
    }

    private void Start()
    {
        musicSource.clip = music;
        musicSource.Play();
        PlaySFX(startSound, 1, 1);
    }
    public void PlaySFX(AudioClip clip, float _volume, float _pitch)
    {
        SFXSource.volume = _volume;
        SFXSource.pitch = _pitch;
        SFXSource.PlayOneShot(clip);
    }
    public void PlaySFX2(AudioClip clip, float _volume, float _pitch)
    {
        SFXSource2.volume = _volume;
        SFXSource2.pitch = _pitch;
        SFXSource2.PlayOneShot(clip);
    }
}
