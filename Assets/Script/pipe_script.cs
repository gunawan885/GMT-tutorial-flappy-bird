using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pipe_script : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadzone = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadzone){
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
