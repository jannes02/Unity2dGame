using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolController : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public Transform emmiterTransform;
    void Start()
    {
        EntityEventMngr.playerShoot += triggerShot;
    }

    // Update is called once per frame
    void triggerShot()
    {
        GameObject bulletInst = Instantiate(bullet, emmiterTransform.position, emmiterTransform.rotation);
        bulletInst.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
        Destroy(bulletInst, 5f);
    }
}
