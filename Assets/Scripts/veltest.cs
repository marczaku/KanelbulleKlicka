using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veltest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        Vector3 vector = new Vector3(100, 0, 0);
        float magnitude = vector.magnitude; // 100
        Vector3 norm = vector.normalized; // (1, 0, 0)
        magnitude = norm.magnitude; // 1

        // CALCULATE DIRECTION: Subtract current position from target position
        Vector3 direction = target.position - transform.position;
        //                      1 origin    -    1 origin          =    0 origin
        
        // JUMP: Add the jump velocity to the current velocity
        rigidbody.velocity = rigidbody.velocity + new Vector3(0, 10, 0);
        //                         0 origin     +         0 origin           =   0 origin
        
        // MOVE: Add a displacement to the current position
        transform.position = transform.position + Vector3.right;
        //                         1 origin      +   0 origin      =  1 origin


        transform.position = transform.position + target.position;
        //                        1 origin      +    1 origin      = 2 origins
    }
}
