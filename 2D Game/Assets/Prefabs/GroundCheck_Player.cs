using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck_Player : MonoBehaviour
{

    private LayerMask layer;
    private bool isColliding;

    public bool isGrounded(LayerMask layer)
    {
        this.layer = layer;
        return isColliding;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.layer == layer)
        {
            isColliding = true;
        }
        else isColliding = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isColliding = false;
    }
}
