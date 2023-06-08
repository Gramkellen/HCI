/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class MuvingcointinItemax : MonoBehaviour {
    public Transform dic;
    bool delay;
	// Use this for initialization
 
	public void GetDich(Transform tranformm)
    {
        dic = tranformm;
    }
	// Update is called once per frame
	void Update () {
        if (dic!= null)
        {
            transform.position = Vector3.Lerp(transform.position, dic.position, 15 * Time.deltaTime);
            if (Mathf.Round(transform.position.x) ==Mathf.Round(dic.position.x)&&
                Mathf.Round(transform.position.y) == Mathf.Round(dic.position.y))
            {
             //   Debug.Log("raaaaaa");
                Slideraxspeed.instance.Muvingojecttotranform(this.gameObject);
             
            }
        }
    }
}
