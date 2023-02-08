using UnityEngine;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject settingsCanvas;

    private void Start()
    {
        settingsCanvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && settingsCanvas.activeSelf)
        {
            mainCanvas.SetActive(true);
            settingsCanvas.SetActive(false);
        }
    }

    public void OpenSettingsMenu()
    {
        if (settingsCanvas.activeSelf)
        {
            mainCanvas.SetActive(true);
            settingsCanvas.SetActive(false);
        }
        else
        {
            mainCanvas.SetActive(false);
            settingsCanvas.SetActive(true);
        }
    }
}
