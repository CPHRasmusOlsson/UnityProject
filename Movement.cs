using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10.4f;
    private UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {   
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if(Input.GetKey("w"))
        {
            pos.y += speed*Time.deltaTime;
        }
        if(Input.GetKey("s"))
        {
            pos.y -= speed*Time.deltaTime;
        }
        if(Input.GetKey("d"))
        {
            pos.x += speed*Time.deltaTime;
        }
        if(Input.GetKey("a"))
        {
            pos.x -= speed*Time.deltaTime;
        }
        transform.position = pos;
    }
}
