using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGestor : MonoBehaviour
{
    public CinemachineVirtualCamera mainMenuCam;   
    public CinemachineVirtualCamera optionsMenuCam; 
    public CinemachineVirtualCamera audioMenuCam;
    public CinemachineVirtualCamera gameCam;
    private void Start()
    {
        ActivateCamera(mainMenuCam);
    }

    public void GoToOptionsMenu()
    {
        ActivateCamera(optionsMenuCam);
    }

    public void GoToAudioMenu()
    {
        ActivateCamera(audioMenuCam);
    }

    public void ReturnToOptionsMenu()
    {
        ActivateCamera(optionsMenuCam);
    }

    public void StartGame()
    {
        ActivateCamera(gameCam);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private void ActivateCamera(CinemachineVirtualCamera cameraToActivate)
    {
        mainMenuCam.Priority = 0;
        optionsMenuCam.Priority = 0;
        audioMenuCam.Priority = 0;
        gameCam.Priority = 0;

        cameraToActivate.Priority = 10;
    }

}
