using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWepon : MonoBehaviour
{
    public Transform weponSystem;

    private Vector2 directionToShoot;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        calcAngle();
        faceMouse();

        if (Input.GetMouseButtonDown(0))
        {
            

            EntityEventMngr.event_playerShoot();
        }
    }

    private void calcAngle()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        directionToShoot = mousePos - (Vector2)weponSystem.position;

       


    }

    private void faceMouse()
    {
        if (directionToShoot.y > 0.001f || directionToShoot.y < -0.001f)
        {
            weponSystem.right = directionToShoot;
            

        }
       




        if (weponSystem.rotation.eulerAngles.z > 90 && weponSystem.rotation.eulerAngles.z < 270)
        {
            weponSystem.GetComponentInChildren<SpriteRenderer>().flipY = true;
        }
        else
        {
            weponSystem.GetComponentInChildren<SpriteRenderer>().flipY = false;
        }
    }

}
