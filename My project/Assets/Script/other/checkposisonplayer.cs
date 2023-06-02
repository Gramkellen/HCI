/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class checkposisonplayer : MonoBehaviour {
    public Transform taget;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Playermuving.isplay)
        {
            transform.position = new Vector3(transform.position.x, taget.transform.position.y, taget.position.z);
        }
    }
}
