/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class ShipMuvinginItro : MonoBehaviour {
    float speed = 10;
	// Use this for initialization
	void Start () {
        if (this.gameObject.name == "Shipmuvingright")
        {
            speed = -10;
        }
        if (this.gameObject.name == "Shipmuvingleft")
        {
            speed = 10;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0,0, speed * Time.deltaTime);
        if (transform.position.x >=10)
        {
            transform.position = new Vector3(transform.position.x - 100,transform.position.y,transform.position.z);

        }
      

    }
}
