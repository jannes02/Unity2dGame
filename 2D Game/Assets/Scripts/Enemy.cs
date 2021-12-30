using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EntityEventMngr.jumpOn += hit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void hit()
    {
        Destroy(gameObject);
    }

    private void OnDisable()
    {
        EntityEventMngr.jumpOn -= hit;
    }

}
