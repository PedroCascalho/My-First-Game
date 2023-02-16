using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        float moveX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocity;
        float moveZ = Input.GetAxisRaw("Vertical") * Time.deltaTime * velocity;
        transform.Translate(moveX, 0, moveZ);
    }
}
