using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class nextMapGenerator : MonoBehaviour
{
    public Collider bound;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("生成下一块地图");
        //Debug.Log(other.name+ other.tag);
        if (other.tag == "Player")
            Copy();//生成新地图
    }

    private void Copy()
    {  
        float len = bound.bounds.extents.z * 2;
   
        Vector3 pos = transform.parent.position + new Vector3(0, 0, len);
        //Debug.Log(bound.bounds);
        Debug.Log("生成新地图 at "+ pos.z);
        Instantiate(transform.parent.gameObject, pos, transform.parent.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
