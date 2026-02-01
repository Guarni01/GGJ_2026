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

        if (!Musiche.isPlaying)
        {
            //PlayNextClip();
        }
    }


    public void PlayClip(int y)
    {
        if (musiclips.Length == 0)
            return;


        Musiche.clip = musiclips[x];
        Musiche.Play();


        indiceclip = (indiceclip + 1) % musiclips.Length;
    }
    public void PlayClipEffect(int x)
    {
        if (effectclips.Length == 0)
            return;


        Effect.clip = musiclips[x];
        Effect.Play();


        indiceclip = (indiceclip + 1) % effectclips.Length;
    }

}
