using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseAudio : MonoBehaviour
{
    public List<AudioClip> audioClips = new List<AudioClip>();
    private AudioClip currentClip;
    public AudioSource source;
    public float minWaitBetweenPlays = 1f;
    private bool isFirsttime = true;
    public float maxWaitBetweenPlays = 5f;

    [Tooltip("Setting to 0f will give the length of the longest clip")]
    public float waitTimeCountdown = -1f;

    // Start is called before the first frame update
    void Start()
    {
        currentClip = audioClips[0];
        if (maxWaitBetweenPlays == 0f) { }
        source = GetComponent<AudioSource>();
        //change volume initially to 0 to stop all sounds playing on launch
        //source.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            if (waitTimeCountdown < 0f)
            {
                currentClip = audioClips[Random.Range(0, audioClips.Count)];
                source.clip = currentClip;
                source.Play();
                waitTimeCountdown = Random.Range(minWaitBetweenPlays, maxWaitBetweenPlays);
            }
            else
            {
                waitTimeCountdown -= Time.deltaTime;
            }
        }
    }
}
