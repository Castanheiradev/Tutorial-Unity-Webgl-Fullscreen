using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Fullscreen : MonoBehaviour
{
    public Image buttonIcon;
    public Sprite fullscreenSprite;
    public Sprite windowedSprite;

    [DllImport("__Internal")]
    public static extern void ToggleFullScreen();

    [DllImport("__Internal")]
    public static extern void RegisterFullscreenEvent();

    private void Awake()
    {
        RegisterFullscreenEvent();
    }

    public void SetFullscreenIcon()
    {
        buttonIcon.sprite = fullscreenSprite;
        Debug.Log("Set fullscreen icon");
    }

    public void SetWindowedIcon()
    {
        buttonIcon.sprite = windowedSprite;
        Debug.Log("Set windowed icon");
    }
}
