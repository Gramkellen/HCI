/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ManagernewSceen : MonoBehaviour {
    public GameObject CarmuVingitro;
    public Transform taget;
    public GameObject banhxe;
    
    public static bool alowmuving;
    public GameObject bus;
    public static bool startmuvingbus  ;
    GameObject cam;
    public List<GameObject> tho = new List<GameObject>();
    public GameObject thotrenxe;
    public static ManagernewSceen Intance;
	// Use this for initialization
	void Start () {
     

        cam = transform.GetChild(2).gameObject;
        startmuvingbus = false;
        Intance = this;
        for (int i = 0; i < tho.Count; i++)
        {
            tho[i].SetActive(false);
        }
        thotrenxe.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (alowmuving&& CarmuVingitro.gameObject.transform.position.z>-7)
        {
            CarmuVingitro.transform.Translate(new Vector3(0,0,-3*Time.deltaTime));
            banhxe.transform.Rotate(200 * Time.deltaTime, 0, 0);
        }
        if (startmuvingbus)
        {
            bus.transform.Translate(0,0,-30*Time.deltaTime);
        }

        //cam.transform.LookAt(taget);

    }
    public void TaiNan()
    {
        banhxe.AddComponent<Rigidbody>();
        banhxe.transform.Rotate(Random.Range(-20,20), Random.Range(-20, 20), Random.Range(-20, 20));
        banhxe.GetComponent<Rigidbody>().AddForce(0, 500, 500);

        StartCoroutine(delayback());
    }
    IEnumerator delayback()
    {
        yield return new WaitForSeconds(0.3f);
        CarmuVingitro.transform.Rotate(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20));
        yield return new WaitForSeconds(0.3f);
        for (int i = 0; i < tho.Count; i++)
        {
            if (managerdata.manager.Getnowcharacter() == tho[i].name)
            {
                tho[i].SetActive(true);
            }
        }
        thotrenxe.SetActive(false);
        yield return new WaitForSeconds(2);
        CarmuVingitro.SetActive(false);


    }
}
