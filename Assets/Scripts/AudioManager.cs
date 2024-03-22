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
    }
    public void PlaySFX(AudioClip clip, float _pitch = 1, float _volume = 1)
    {
        SFXSource.PlayOneShot(clip);
    }
}
