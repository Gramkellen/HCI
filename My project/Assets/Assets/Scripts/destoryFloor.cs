using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class destoryFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            
            objGenerator childComponent = transform.parent.GetComponent<objGenerator>();
            while (childComponent.obstacles.Count > 0)//摧毁所有障碍物
            {
                GameObject obstacle = childComponent.obstacles[0];
                childComponent.obstacles.RemoveAt(0);
                Destroy(obstacle);
            }
            Debug.Log("摧毁障碍物");
            Destroy(transform.parent.gameObject);//摧毁地图
            Debug.Log("摧毁上一级地图");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
