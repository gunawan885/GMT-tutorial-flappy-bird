using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D myriggidbody;
    public float flapstreght;
    public logic_script logic;
    public bool birdisalive = true;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Birds";
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive==true){
        myriggidbody.velocity = Vector2.up*flapstreght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisalive = false;
    }
}
