using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5000;
    private Rigidbody body;
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();   
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("人物碰撞");
        //Debug.Log(other.name);
    }
    // Update is called once per frame
    void Update()
    {
        body.velocity = transform.TransformDirection(new Vector3(0,0,1))*speed*Time.deltaTime ;//向z轴稳定的速度
        //Debug.Log(GetComponent<Transform>().position);
    }
}
