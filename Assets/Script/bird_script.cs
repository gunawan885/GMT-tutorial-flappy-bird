using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myriggidbody;
    public float flapstreght;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Birds";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        myriggidbody.velocity = Vector2.up*flapstreght;
        }
    }
}
