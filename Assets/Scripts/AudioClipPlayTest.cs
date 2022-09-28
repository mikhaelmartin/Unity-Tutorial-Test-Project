using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipPlayTest : MonoBehaviour
{
    [SerializeField] AudioClip clip;

    public void PlaySound() {
        AudioSource.PlayClipAtPoint(clip, Vector3.zero);
    }
}
