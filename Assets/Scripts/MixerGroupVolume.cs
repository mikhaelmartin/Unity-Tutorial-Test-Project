using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerGroupVolume : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] string parameter;
    [SerializeField, Range(0, 1f)] float volume=1;

    private void Update()
    {
        audioMixer.SetFloat(parameter, LinearToDecibel(volume));
    }

    private float LinearToDecibel(float linear)
    {
        // linear = linear < 0.0001f ? 0.0001f : linear; 
        linear = Mathf.Clamp(linear, 0.0001f, 1);
        return 20 * Mathf.Log10(linear);
    }
}
