/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class BollEffcts : MonoBehaviour {
    bool issow;
    Vector3 lave;
    public static BollEffcts instance;
	// Use this for initialization
	void Start () {
        instance = this;
        lave = transform.localScale;
        issow = false;
        Open();
        
    }

  public  void Open()
    {
        issow = true;
        speed = 3;
        StartCoroutine(delayhide(true));
    }
    public void Close()
    {
        issow = true;
        speed = -3;

        StartCoroutine(delayhide(false));

    }
    void OnEnable()
    {
        if (managerdata.manager.getsetting() == 1)
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }

    }
    IEnumerator delayhide(bool value)
    {
        yield return new WaitForSeconds(3);
        issow = false;
        if (value == false)
        {
            this.gameObject.SetActive(false);
        }
    }
    float speed = 3;
	// Update is called once per frame
	void Update () {
        if (issow)
        {
            transform.localScale += new Vector3(speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);
        }
        transform.Rotate(new Vector3(6, 5, 4));
    }
}
