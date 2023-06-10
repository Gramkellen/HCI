using System.Collections;
using System.Collections.Generic;
// using UnityEngine;

// public class destoryCoin : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }

using UnityEngine;

public class DestroyCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if (other.CompareTag("Player"))
        // {
        //     // 如果与coin碰撞的是Player对象
        //     // 执行coin消失的逻辑
        //     Destroy(gameObject); // 销毁coin对象
        //     Debug.Log("摧毁硬币*1");
        // }
    }
}
