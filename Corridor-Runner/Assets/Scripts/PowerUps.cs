using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public PowerupsEffect PowerupsEffect;

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);
        PowerupsEffect.Apply(collision.gameObject);

    }
    
}
