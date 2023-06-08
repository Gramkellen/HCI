/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class Showandhide : MonoBehaviour {
    public GameObject MEnubuy;
    public GameObject thismenu;
    public GameObject player;
    public GameObject map;
    GameObject cam;
    // Use this for initialization
    void Start () {
	}
	public void backcameratobehigh()
    {
        MEnubuy.SetActive(true);
        thismenu.SetActive(false);
        Playermuving.player.OpenMenu3D();
        map.SetActive(false);
        cam = gameObject.transform.GetChild(2).gameObject;
        GetComponent<Animator>().enabled = false;
        cam.GetComponent<Camera>().orthographic = true;
        cam.GetComponent<Camera>().farClipPlane = 1.81f;
    }
    public void gotothemain()
    {
        #region MyRegion
        thismenu.SetActive(true);
        Playermuving.player.loadinganimation();
        MEnubuy.SetActive(false);
        map.SetActive(true);
        cam.GetComponent<Camera>().orthographic = false;
        cam.GetComponent<Camera>().farClipPlane = 100;
        transform.root.gameObject.GetComponent<Animator>().enabled = true;
        #endregion

    }

}
