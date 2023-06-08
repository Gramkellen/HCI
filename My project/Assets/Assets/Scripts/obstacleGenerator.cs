using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGenerator : MonoBehaviour
{
    public GameObject bus1;
    public GameObject bus2;
    public GameObject uphill;
    public GameObject down_ob;
    public GameObject up_ob;
    public GameObject down_up_ob;
    public Collider bound;//地图的一个子组件，用于标定世界坐标下的地图长度
    private float len;//地图长度的二分之一
    private float[,,] pos_list = new float[6, 3, 2] {
        {//bus1三道坐标 相对父组件
            {-10.26923f,-36.5531f },
            {-7.59f,-36.5531f },
            {-4.95f,-36.5531f }
        },
        {//bus2三道坐标-10.27
            {-10.27f, -36.5531f},
            { -7.62f,-36.5531f},
            { -5.109234f,-36.5531f}
        },
        {//uphill三道坐标
            {-10.41f ,-37.71f},
            { -7.72f,-37.71f},
            {-5.07f, -37.71f}
        },
        {//down_ob三道坐标
            {-10.34923f,-36.11744f },
            {-7.76f,-36.11744f },
            {-5.25f,-36.11744f }
        },
        {//up_ob三道坐标
            {-10.34923f,-37.95744f },
            {-7.76f,-37.95744f },
            {-5.289234f,-37.95744f }
        },
        {//down_up_ob三道坐标
            {-10.34923f,-36.91f },
            {-7.76f,-36.91f },
            {-5.25f,-36.91f }
        }

    };
    public List<GameObject> obstacles;//收集所有障碍物，便于销毁
     
    // Start is called before the first frame update
    void Start()
    {
        obstacles = new List<GameObject>();
        len = bound.bounds.extents.z;
        //Debug.Log(len);
        //Debug.Log(transform.position);
        ObstacleSet();

    }
    private void ObstacleSet()
    {
        int num = Random.Range(10,20);
        for(int i =0;i<num; i++)
        {
            int ob=Random.Range(0,6);
            switch(ob)
            {
                case 0:bus1Set();
                break;
                case 1:bus2Set(); 
                break;
                case 2:uphillSet();
                break;
                case 3:downOBSet();
                break;  
                case 4:upOBSet();
                break;
                case 5:downupOBSet();
                break;
            }
        }
    }
    void bus1Set()
    {
        int road= Random.Range(0,3);
        GameObject obj = Instantiate(bus1, transform.position + new Vector3(pos_list[0, road, 0], pos_list[0, road, 1], Random.Range(-220f, 10f)), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void bus2Set()
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(bus2, transform.position + new Vector3(pos_list[1, road, 0], pos_list[1, road, 1], Random.Range(-220f, 10f)), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void uphillSet()
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(uphill, transform.position + new Vector3(pos_list[2, road, 0], pos_list[2, road, 1], Random.Range(-220f, 10f)), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void downOBSet()
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(down_ob, transform.position + new Vector3(pos_list[3, road, 0], pos_list[3, road, 1], Random.Range(-220f, 10f)), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void upOBSet()
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(up_ob, transform.position + new Vector3(pos_list[4, road, 0], pos_list[4, road, 1], Random.Range(-220f, 10f)), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void downupOBSet()
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(down_up_ob, transform.position + new Vector3(pos_list[5, road, 0], pos_list[5, road, 1], Random.Range(-220f, 10f)), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
