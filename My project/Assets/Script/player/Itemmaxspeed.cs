/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class Itemmaxspeed : MonoBehaviour {
    public GameObject createship, createship1, taucat,taudi,thanhchancao,thanhcahnthap,thanhchanvua,cotdien;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "baycao"|| coll.gameObject.tag == "bay")
        {
            Destroy(coll.gameObject.transform.root.gameObject);
        }
        if (coll.gameObject.tag == "die" || coll.gameObject.tag == "ship" || coll.gameObject.tag == "shipnotdie" || coll.gameObject.tag == "thanhchan" || coll.gameObject.tag == "cau" || coll.gameObject.tag == "taucat")
        {

            GameObject mk, betwent = null;
            if (coll.gameObject.name != "checkleft"&&coll.gameObject.name != "checkrigh")
            {
                switch (coll.gameObject.transform.root.gameObject.name)
                {
                    case "tauchet2(Clone)": // tàu mùa xanh
                        betwent = createship;
                        break;
                    case "tauchet1(Clone)": // tàu mùa vàng toa
                        betwent = createship1;
                        break;
                    case "toa(Clone)":
                        betwent = taucat;
                        break;
                    case "tauchetdi(Clone)": //thanhchancao
                        betwent = taudi;
                        break;
                    case "thanhchancao(Clone)": //thanhchancao Cot_den
                        betwent = thanhcahnthap;
                        break;
                    case "thanhchancaolon(Clone)":
                        betwent = thanhchancao;
                        break;
                    case "thanhchanthap(Clone)":
                        betwent = thanhchanvua;
                        break;
                    case "pCylinder14(Clone)":
                        betwent = cotdien;
                        break;
                    default:
                        betwent = createship;
                        break;
                }
                mk = Instantiate(betwent, coll.transform.position, coll.transform.rotation) as GameObject;
                StartCoroutine(delayBum(mk));
                coll.gameObject.transform.root.gameObject.SetActive(false);
            }

        }
      
    }
    IEnumerator delayBum(GameObject _object)
    {
        _object.AddComponent<Rigidbody>();
        _object.transform.GetChild(0).gameObject.AddComponent<BoxCollider>().enabled = false;
        _object.transform.Rotate(new Vector3(Random.Range(-20,20), Random.Range(-20, 20), Random.Range(-20, 20 )));
        _object.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-8,8), Random.Range(10, 30), Random.Range(50, 70));
        yield return new WaitForSeconds(0.5f);
        _object.transform.GetChild(0).gameObject.GetComponent<BoxCollider>().enabled = true;
        yield return new WaitForSeconds(1.5f);
        if (_object!= null)
        {
             if (_object.transform.childCount >0)
        {
                _object.transform.GetChild(0).GetComponent<BoxCollider>().enabled = false;
        _object.GetComponent<Rigidbody>().velocity = new Vector3(0, -5, 0);

            }
        }
       
       
        yield return new WaitForSeconds(1f);
        Destroy(_object);
    }
    IEnumerator delayBumthis(GameObject _object ,Transform position ,Transform rotation)
    {
        _object.AddComponent<Rigidbody>();
        _object.AddComponent<BoxCollider>();
        _object.transform.Rotate(new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20)));
        _object.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-8, 8), Random.Range(10, 20), Random.Range(30, 50));
        yield return new WaitForSeconds(1.5f);
        _object.GetComponent<BoxCollider>().enabled = false;
        _object.GetComponent<Rigidbody>().velocity = new Vector3(0, -5, 0);
        yield return new WaitForSeconds(1f);
        _object.GetComponent<BoxCollider>().enabled = false;
        Destroy(_object.GetComponent<Rigidbody>());
        _object.transform.position = position.position;
        _object.transform.eulerAngles = rotation.eulerAngles;
    }
}
