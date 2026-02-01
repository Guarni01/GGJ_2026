using UnityEngine;
using UnityEngine.UI;
public class AudioController : MonoSingleton<AudioController>
{
    public Slider volumeSliderEffect;
    public Slider volumeSliderMusic;
    public AudioSource Musiche;
    public AudioClip[] musiclips;
    public AudioSource Effect;
    public AudioClip[] effectclips; 


    private int indiceclip = 0;

    void Start()
    {
        

        if (Musiche == null)
        {
            Musiche = GetComponent<AudioSource>();
        }
    }

    void Update()
    {
        volumeSliderMusic.value = Musiche.volume;
        volumeSliderEffect.value = Effect.volume;

        volumeSliderMusic.onValueChanged.AddListener(OnVolumeChanged);
        volumeSliderEffect.onValueChanged.AddListener(OnVolumeChanged);
        if (!Musiche.isPlaying)
        {
            //PlayNextClip();
        }
    }

    public void OnVolumeChanged(float value)
    {
        Musiche.volume = value;
        Effect.volume = value;
    }
    //void PlayNextClip()
    //{
    //    if (musiclips.Length == 0)
    //        return;


    //    Musiche.clip = musiclips[indiceclip];
    //    Musiche.Play();


    //    indiceclip = (indiceclip + 1) % musiclips.Length;
    //}
}
