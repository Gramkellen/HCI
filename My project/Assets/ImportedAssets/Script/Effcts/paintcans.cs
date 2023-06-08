/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class paintcans : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public GameObject PHUN;
    // Update is called once per frame
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "pain")
        {
            PHUN.gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider coll)
    {

        if (coll.gameObject.name == "pain")
        {
            PHUN.gameObject.SetActive(false);
        }
    }

    }
