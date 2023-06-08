/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class Intheitem : MonoBehaviour {
   public GameObject con;
	// Use this for initialization
	void Start () {
    //    Destroy(this.gameObject,20);
        con = gameObject.transform.Find("conitem").gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (con.gameObject !=  null)
        {
            con.transform.Rotate( new Vector3(0,0,50*Time.deltaTime));
        }
        if (Playermuving.isplay == false)
        {
            Destroy(this.gameObject);
        }

    }
}
