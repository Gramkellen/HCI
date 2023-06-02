/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {
    bool rotaychidcoi;
   public  GameObject rotaychidcoimian;
    // Use this for initialization
    void Start () {
        rotaychidcoi = false;
        
        StartCoroutine(timer());
    }
	IEnumerator timer()
    {
        float ran = Random.Range(0, 1f);
        yield return new WaitForSeconds(ran);
        rotaychidcoi = true;
    }
	// Update is called once per frame
	void Update () {
        if (rotaychidcoi)
        {
            
            rotaychidcoimian.transform.Rotate(new Vector3(0, 150 * Time.deltaTime, 0));
        }
        if (Playermuving.player)
        {
            if (transform.position.z < Playermuving.player.transform.position.z - 10)
            {
              // Destroy(this.gameObject);
            }
        }
        if (Playermuving.isplay == false&&Playermuving.player.gameObject.transform.position.z >10)
        {
           Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "ship")
        {
          //  Destroy(this.gameObject);
        }
    }
}
