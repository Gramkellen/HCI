/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Delaystart : MonoBehaviour {
    public Text delaysecon;
    // Use this for initialization
    void Start () {
        delaysecon.text = delaysecons.ToString();
        delaysecons = 3;
    }


   public static int delaysecons = 3;
    public void showdelaytext()
    {
        delaysecon.text = delaysecons.ToString();
        delaysecons--;
        if (delaysecons ==0)
        {
            delaysecons = 3;
//            GetComponent<Animator>().Stop();
            Time.timeScale = inthepanelpause.datatime;
            this.gameObject.SetActive(false);
        }
    }
    public void Getvalue()
    {
        delaysecon.text = delaysecons.ToString();

    }
}
