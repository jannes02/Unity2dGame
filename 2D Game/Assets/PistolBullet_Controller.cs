using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet_Controller : MonoBehaviour
{

    [SerializeField] private LayerMask plattformLayerMask;
    [SerializeField] private LayerMask enemyLayer;
    [SerializeField] private GameObject impactParticleSystem;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Physics2D.Raycast(transform.position, Vector2.right, transform.localScale.y / 2 + 0.1f, plattformLayerMask)){
            Destroy(gameObject);
        }*/
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISION");

        if (collision.gameObject.tag == "SolidPlattform")
        {
            GameObject impactInst = Instantiate(impactParticleSystem, transform.position, transform.rotation);
            impactInst.transform.Find("Impact_PS").GetComponent<ParticleSystem>().Play();
            Destroy(impactInst, 0.5f);
           
            
            Destroy(gameObject, 0.5f);
        }
    }

}
