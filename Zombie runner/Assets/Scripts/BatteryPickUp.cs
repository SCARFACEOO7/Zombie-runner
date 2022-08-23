using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
   [SerializeField] float intensityAmount = 1f;
   [SerializeField] float restoreAngle = 3f;
   FlashLight flashLight;

   private void OnTriggerEnter(Collider other) 
   {
       if(other.gameObject.tag == "Player")
       {
           other.GetComponentInChildren<FlashLight>().RestoreLightAngle(restoreAngle);
           other.GetComponentInChildren<FlashLight>().RestoreLightIntensity(intensityAmount);
           Destroy(gameObject);
       }
   }
}
