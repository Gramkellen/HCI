using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objGenerator : MonoBehaviour
{
    public GameObject bus1;
    public GameObject bus2;
    public GameObject uphill;
    public GameObject down_ob;
    public GameObject up_ob;
    public GameObject down_up_ob;
    public GameObject coinSet;
    public GameObject Coin_Dollar;

    public GameObject Coin_Lucky;
    public GameObject Coin_Death;



    public Collider bound;//地图的一个子组件，用于标定世界坐标下的地图长度
    private float len;//地图长度的二分之一
    private float[,,] pos_list = new float[7, 3, 2] {
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
        },
        {//coinSet三道坐标
            // {-5.15f,-30f },
            // {-7.65f,-30f },
            // {-2.5f,-30f },
            {-10.34923f,-33.91f },
            {-7.76f,-33.91f },
            {-5.25f,-33.91f }
        }



    };
    public List<GameObject> obstacles;//收集所有障碍物，便于销毁
     
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is objGen test");
        obstacles = new List<GameObject>();
        len = bound.bounds.extents.z;
        Debug.Log("bound.bounds.extents.z=="+len);
        Debug.Log("transform.position=="+transform.position);
        float r1 = Random.Range (0f, 1f);
       
        ObstacleSet();           
    }
    private void ObstacleSet()
    {
        //int num = Random.Range(10,20);
        int count=10;
        for(int i =0;i<count; i++)
        {
            int ob=Random.Range(0,13);
            switch(ob)
            {
                case 0:bus1Set(i);
                break;
                case 1:bus2Set(i); 
                break;
                case 2:uphillSet(i);
                break;
                case 3:downOBSet(i);
                break;  
                case 4:upOBSet(i);
                break;
                case 5:downupOBSet(i);
                break;
                case 6:coinSetSet(i);
                break;
                case 7:coinSetSet(i);
                break;
                case 8:coinSetSet(i);
                break;
                case 9:coinSetSet(i);
                break;
                case 10:Coin_LuckySet(i);
                break;
                case 11:Coin_DollarSet(i);
                break;
                case 12:Coin_DeathSet(i);
                break;
            }
        }
    }


    void bus1Set(int count)
    {
        int road= Random.Range(0,3);
        GameObject obj = Instantiate(bus1, transform.position + new Vector3(pos_list[0, road, 0], pos_list[0, road, 1], -230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void bus2Set(int count)
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(bus2, transform.position + new Vector3(pos_list[1, road, 0], pos_list[1, road, 1], -230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void uphillSet(int count)
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(uphill, transform.position + new Vector3(pos_list[2, road, 0], pos_list[2, road, 1], -230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void downOBSet(int count)
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(down_ob, transform.position + new Vector3(pos_list[3, road, 0], pos_list[3, road, 1], -230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void upOBSet(int count)
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(up_ob, transform.position + new Vector3(pos_list[4, road, 0], pos_list[4, road, 1],-230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void downupOBSet(int count)
    {
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(down_up_ob, transform.position + new Vector3(pos_list[5, road, 0], pos_list[5, road, 1], -230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    void coinSetSet(int count){
        Debug.Log("当前正在运行coinSetSet");
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(coinSet, transform.position + new Vector3(pos_list[6, road, 0], pos_list[6, road, 1], -230+count*23), transform.rotation);
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    
    void Coin_LuckySet(int count){
        int road = Random.Range(0, 3);
        GameObject obj = Instantiate(Coin_Lucky, transform.position + new Vector3(pos_list[6, road, 0], pos_list[6, road, 1]-3f, -230+count*23), Quaternion.Euler(90, 0, 0));
        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }
    
    void Coin_DollarSet(int count){
        int road = Random.Range(0, 3);

        GameObject obj = Instantiate(Coin_Dollar, transform.position + new Vector3(pos_list[6, road, 0], pos_list[6, road, 1]-3f, -230+count*23), Quaternion.Euler(90, 0, 0));//

        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }

    void Coin_DeathSet(int count){
        int road = Random.Range(0, 3);

        GameObject obj = Instantiate(Coin_Death, transform.position + new Vector3(pos_list[6, road, 0], pos_list[6, road, 1]-3f, -230+count*23), Quaternion.Euler(90, 0, 0));

        //Debug.Log(obj.transform.position);
        obstacles.Add(obj);
        //随机生成
    }




    
    // Update is called once per frame
    void Update()
    {
        
    }
}
