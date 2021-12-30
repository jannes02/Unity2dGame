
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    public Transform target;

    [Range(0f, 50f)]
    public float smoothSpeed;
 
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position - Vector3.forward * 10, smoothSpeed * Time.deltaTime);
       
    }
}
