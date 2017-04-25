using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolumeSlider : MonoBehaviour {

    public Slider volume;
    public AudioSource audioSource;
	
	// Update is called once per frame
	void Update () {
        audioSource.volume = volume.value;
	}
}
