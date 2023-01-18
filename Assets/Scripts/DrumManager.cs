using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumManager : MonoBehaviour
{
    AudioSource _audioSource;
    private void Start() {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other) {
        _audioSource.pitch = Random.Range(0f,2f);
        _audioSource.volume = other.relativeVelocity.magnitude;
        _audioSource.Play();
        
    }
}
