/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class Cotdien : MonoBehaviour {
    public GameObject Child;
    float time;
    bool onoff;
	// Use this for initialization
	void Start () {
        Child = gameObject.transform.Find("cd").gameObject;

    }
	void OnOFF()
    {
        onoff = !onoff;
        if (onoff)
        {
            Child.SetActive(false);
        }
        else
        {
            Child.SetActive(true);
        }
    }
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if (time >=0.5)
        {
            OnOFF();
            time = 0;
        }
	}
}
