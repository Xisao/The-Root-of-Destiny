using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        // Set the initial volume based on the current AudioListener volume
        volumeSlider.value = AudioListener.volume;

        // Add a listener to the slider's onValueChanged event
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    private void SetVolume(float volume)
    {
        // Set the AudioListener volume to the value of the slider
        AudioListener.volume = volume;
    }
}
