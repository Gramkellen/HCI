/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;
/// <summary>
/// xử lý tâng player lên khi có item giày
/// </summary>
public class Onhaveitemgiay : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag != "coin"&& coll.gameObject.tag != this.gameObject.tag&& coll.gameObject.tag != "Player")
        {
            if (Playermuving.isplay)
            {
                Playermuving.player.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
                Physics.gravity = new Vector3(0, -15, 0);
            }
        }
     
    }

}
