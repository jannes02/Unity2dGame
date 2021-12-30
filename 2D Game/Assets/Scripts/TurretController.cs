using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [SerializeField] private GameObject l1, l2;

    void Start()
    {
        EntityEventMngr.jumpOn += turnOff;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void turnOff()
    {
        l1.SetActive(false);
        l2.SetActive(false);
    }
}
