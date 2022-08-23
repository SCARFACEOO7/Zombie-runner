using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float maxHP=100f;
    
    public void ProcessHit(float damage)
    {
        maxHP -= damage;
        if(maxHP <= 0)
        {
           GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
