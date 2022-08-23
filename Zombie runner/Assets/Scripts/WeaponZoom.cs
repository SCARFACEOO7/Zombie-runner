using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedINSensitivity = 0.5f;
    [SerializeField] float zoomedOutSensitivity = 2f;

    [SerializeField] RigidbodyFirstPersonController fpsController;

    bool zoomedInToggle = false;
    
    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIN();
            }
            else
            {
                ZoomOUT();
            }

        }
    }
    private void OnDisable() 
    {
        ZoomOUT();
    }

    void ZoomIN()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomedINSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedINSensitivity;
    }

    void ZoomOUT()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
    }
}
