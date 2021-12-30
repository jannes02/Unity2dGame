using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Movement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private LayerMask plattformLayerMask;
    [SerializeField] private LayerMask enemyLayer;   
    private float accMultipl = 10;
    private float lowjumpMultiplier = 2.5f;
    private float fallMultiplier = 2f;
    [Range( 1, 10)]
    public float jumpVel;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

       
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.velocity = Vector2.up * jumpVel;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowjumpMultiplier - 1) * Time.deltaTime;
        }

        if (isGroundedWithSpeceficLayer(enemyLayer))
        {
            EntityEventMngr.event_jumpOn();
        }


    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * accMultipl, rb.velocity.y);

      

    }

    private bool isGrounded()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, transform.localScale.y / 2 + 0.1f, plattformLayerMask);
        Debug.DrawRay(transform.position, transform.position * (transform.localScale.y / 2 + 0.1f), Color.green);
        //return transform.Find("GroundCheck").GetComponent<GroundCheck_Player>().isGrounded(plattformLayerMask);
    }

    private bool isGroundedWithSpeceficLayer(LayerMask layerMask)
    {
        return Physics2D.Raycast(transform.position, Vector2.down, transform.localScale.y / 2 + 0.1f, layerMask);
        //return transform.Find("GroundCheck").GetComponent<GroundCheck_Player>().isGrounded(layerMask);
        //return true;
    }

}
