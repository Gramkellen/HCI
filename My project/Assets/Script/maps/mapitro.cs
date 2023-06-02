/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class mapitro : MonoBehaviour {
    public static mapitro instance;
    public GameObject muvingship, CSSidie, CSSrun;
    public GameObject mapitroativer;
	// Use this for initialization
	void Start () {
        instance = this;

    }
  public	void Muvingship()
    {
        CSSidie.SetActive(false);
       // muvingship.GetComponent<ShipMuvinginItro>().enabled = true;
    }
	 public void HidemapItro()
    {
        mapitroativer.SetActive(false);
    }
}
