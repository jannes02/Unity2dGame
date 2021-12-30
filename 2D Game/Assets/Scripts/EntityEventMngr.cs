using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EntityEventMngr : MonoBehaviour
{
    public static event Action jumpOn;
    public static event Action playerShoot;
   

    // Update is called once per frame
    void Update()
    {
       
    }

    public static void event_jumpOn()
    {
        jumpOn?.Invoke();
    }

    public static void event_playerShoot()
    {
        playerShoot?.Invoke();
    }
}
