/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class rotaychilditem : MonoBehaviour {
    GameObject child;
    public bool istrue;
	// Use this for initialization
	void Start () {
        istrue = false;
        child = transform.Find("item").gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (istrue)
        {
            if (Canvatbuyshop.openshopcharacter)
            {
            child.transform.Rotate(new Vector3(0,0,1.5f));
            }
            else
            {
                child.transform.Rotate(new Vector3(0, 0, 4));
            }
        }
	
	}
}

