using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObstacle : MonoBehaviour
{
    [SerializeField] private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity *= Time.deltaTime; //velocity = velocity * Time.deltaTime
    }

    // Update is called once per frame
    void Update()
    {        
        transform.Rotate(0, velocity * Time.deltaTime, 0);
    }
}
