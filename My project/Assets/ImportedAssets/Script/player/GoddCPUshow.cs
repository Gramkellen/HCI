/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class GoddCPUshow : MonoBehaviour {
    public GameObject   bumitem;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "bay" || coll.gameObject.tag == "baycao" || coll.gameObject.tag == "iteamgiay" || coll.gameObject.tag == "hopqua" || coll.gameObject.tag == "key" || coll.gameObject.tag == "namcham" || coll.gameObject.tag == "van"||coll.gameObject.tag == "x2coin")
        {
           // Instantiate(bumitem, coll.transform.position, transform.rotation);
            int load =  coll.gameObject.transform.childCount;
            for (int i = 0; i < load; i++)
            {
                coll.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "bay" || coll.gameObject.tag == "baycao" || coll.gameObject.tag == "iteamgiay" || coll.gameObject.tag == "hopqua" || coll.gameObject.tag == "key" || coll.gameObject.tag == "namcham" || coll.gameObject.tag == "van")
        {
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == "map")
        {
         //   coll.transform.root.gameObject.SetActive(false);
        }
    }
    
}
