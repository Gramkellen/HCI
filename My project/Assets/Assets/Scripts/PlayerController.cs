// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerController : MonoBehaviour
// {
//     private float speed = 5000;
//     private Rigidbody body;
//     private Animation anim;
//     // Start is called before the first frame update
//     void Start()
//     {
//         body = GetComponent<Rigidbody>();
//         anim = GetComponent<Animation>();   
//     }
//     private void OnTriggerEnter(Collider other)
//     {
//         //Debug.Log("人物碰撞");
//         //Debug.Log(other.name);
//     }
//     // Update is called once per frame
//     void Update()
//     {
//         body.velocity = transform.TransformDirection(new Vector3(0,0,1))*speed*Time.deltaTime ;//向z轴稳定的速度
//         //Debug.Log(GetComponent<Transform>().position);
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5000;
    private Rigidbody body;
    private Animation anim;
    private bool canMove = false; // 新增一个变量用于控制是否可以移动

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();   

        body.isKinematic = true; // 初始状态下禁用刚体运动
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("人物碰撞");
        //Debug.Log(other.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;
            body.velocity = movement;

            // 在此处添加动画控制代码
        }

        if (Input.GetKeyDown(KeyCode.Space)) // 在按下空格键后开始移动
        {
            canMove = true;
            body.isKinematic = false; // 启用刚体运动
        }
    }
}
