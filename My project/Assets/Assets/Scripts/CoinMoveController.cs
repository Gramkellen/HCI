using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveController : MonoBehaviour {
    //金币移动的的目标
    GameObject target;
    //金币是否可以移动
    public bool isCanMove = false;
    //金币移动的速度
    public float speed = 50;
	// Use this for initialization
	void Start () {
        //获取玩家
        target = GameObject.FindGameObjectWithTag("Player");
	}
	
    
	// Update is called once per frame
	void Update () {
        if (isCanMove)
        {
            //金币向玩家移动的速度
            transform.position = Vector3.MoveTowards(transform.position,target.transform.position,Time.deltaTime*speed);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        //如果金币碰到的物体是玩家
        if (other.tag.Equals("Player"))
        {
            //金币碰到玩家后就会销毁金币
            Destroy(gameObject);
        }
    }
}

