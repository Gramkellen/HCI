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

public class ShowCharacterinmenulost : MonoBehaviour {
    public List<GameObject> Allplayer = new List<GameObject>();
    public Transform allplayer;
    // Use this for initialization
    void Start () {
        foreach (Transform item in allplayer)
        {
            Allplayer.Add(item.gameObject);
        }
        Getcharacter();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Getcharacter()
    {
        for (int i = 0; i < Allplayer.Count; i++)
        {
            if (managerdata.manager.Getnowcharacter() == Allplayer[i].name)
            {
                Allplayer[i].SetActive(true);
            }
            else
            {
                Allplayer[i].SetActive(false);
            }
        }
    }
    void OnEnable()
    {
        Getcharacter();
    }
}
