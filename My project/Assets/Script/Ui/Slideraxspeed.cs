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
using System.Collections.Generic;

public class Slideraxspeed : MonoBehaviour {
    public static Slideraxspeed instance;
    public GameObject _showmaxspeed;
    public Image _imgshowmaxspeed;
    public Text _Showloaddelay;
    public GameObject _kim;
    public GameObject makeintance;
    public GameObject maxspeedojectanimator;
    public GameObject effctpaler;

    // Use this for initialization
    // 10 cái thì o k
    void Start () {
        IntheuseingItem = false;
        instance = this;
        IntheuseingItem = false;
        CreateOject();
    }

    public List<GameObject> Hidecoin = new List<GameObject>();
    public List<GameObject> Showcoin = new List<GameObject>();
    public List<GameObject> HidecoininGame = new List<GameObject>();
    public List<GameObject> ShowcoininGame = new List<GameObject>();
    public GameObject coin;
    void CreateOject()
    {
        for (int i = 0; i < 15; i++)
        {
            Hidecoin.Add(Instantiate(makeintance, makeintance.transform.position, makeintance.transform.rotation) as GameObject);
        }
        for (int i = 0; i < Hidecoin.Count; i++)
        {
            Hidecoin[i].gameObject.transform.SetParent(makeintance.transform);
            Hidecoin[i].gameObject.GetComponent<Image>().enabled = true;
            Hidecoin[i].SetActive(false);
            Hidecoin[i].AddComponent<MuvingcointinItemax>();
            Hidecoin[i].GetComponent<MuvingcointinItemax>().GetDich(_kim.transform);
        }
        for (int i = 0; i < 20; i++)
        {
            HidecoininGame.Add(Instantiate(coin, makeintance.transform.position, makeintance.transform.rotation) as GameObject);
        }
        for (int i = 0; i < HidecoininGame.Count; i++)
        {
            HidecoininGame[i].transform.position = Playermuving.player.gameObject.transform.position;
            HidecoininGame[i].transform.SetParent(Playermuving.player.gameObject.transform);
        }
    }


 public static   bool IntheuseingItem;
    public void Getvalue()
    {
        if (_imgshowmaxspeed.fillAmount<1&& IntheuseingItem ==false)
        {
            _imgshowmaxspeed.fillAmount += 0.005f;
            _Showloaddelay.text = (Mathf.Round( _imgshowmaxspeed.fillAmount * 100)).ToString() + "%";
            if (Hidecoin.Count>=1)
            {
                Hidecoin[0].gameObject.SetActive(true);
                Hidecoin[0].transform.SetParent(_kim.transform);
                Showcoin.Add(Hidecoin[0]);
                Hidecoin.Remove(Hidecoin[0]);
            }
         
            _kim.transform.Rotate(new Vector3(0,0,-0.9f));
        }
        if (_imgshowmaxspeed.fillAmount == 1)
        {
            maxspeedojectanimator.GetComponent<Animator>().enabled = true;
            maxspeedojectanimator.GetComponent<Animator>().SetInteger("value",1);
        }
        
      StartCoroutine(delaycoin(value++));
    }
    int value = 0;
    IEnumerator delaycoin(int vl)
    {
        if (vl== HidecoininGame.Count - 1)
        {
            value = 0;
            vl = 0;
        }
        if (managerdata.manager.getsetting() == 1)
        {
            HidecoininGame[vl].gameObject.SetActive(true);
            HidecoininGame[vl].gameObject.GetComponent<AudioSource>().pitch = Soundmanager.pitchsound;
            HidecoininGame[vl].gameObject.GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(0.5f);
            HidecoininGame[vl].gameObject.SetActive(false);
            HidecoininGame[vl].gameObject.GetComponent<AudioSource>().Stop();
        }
      

    }
    public void Muvingojecttotranform(GameObject oject)
    {
       
        oject.SetActive(false);
        oject.transform.position = makeintance.transform.position;
        oject.transform.SetParent(makeintance.transform);
        Hidecoin.Add(oject);
    }
    public void Getfalse()
    {
      
        _kim.transform.eulerAngles = new Vector3(0, 0, 0);
        maxspeedojectanimator.GetComponent<Animator>().SetInteger("value", 3); ;
        IntheuseingItem = false;
        _imgshowmaxspeed.fillAmount = 0;
        _Showloaddelay.text = (Mathf.Round(_imgshowmaxspeed.fillAmount * 100)).ToString() + "%";
    }
    GameObject player;
    public void ClicToMaxSpeed()
    {
        if (_imgshowmaxspeed.fillAmount==1&&Manageritem.baylongcoin==false)
        {
            effctpaler.SetActive(true);
            effctpaler.GetComponent<BollEffcts>().Open();
            maxspeedojectanimator.GetComponent<Animator>().SetInteger("value", 2); ;
              player = Playermuving.player.GetojectPlayer();
            Debug.Log("slsksksksk"+player.name);
            player.GetComponent<Animator>().SetBool("maxspeed", true);
            IntheuseingItem = true;
            _showmaxspeed.SetActive(true);
            StartCoroutine(DelayMaxSpeed());
            Soundmanager.soundmanager.PlayItemMax();
        }
    }
    IEnumerator DelayMaxSpeed()
    {
        if (Playermuving.speedmuving <15)
        {
            Playermuving.speedmuving = 15;
        }
        Playermuving.speedmuving = Playermuving.speedmuving*2;
        if (Playermuving.speedmuving<30)
        {
            Playermuving.speedmuving = 30;
        }

        StartCoroutine(camerafile());
        for (int i = 0; i < 100; i++)
        {
            if (IntheuseingItem == false)
            {
                break;
            }
            _kim.transform.Rotate(new Vector3(0, 0, 1.8f));
            yield return new WaitForSeconds(0.1f);
            _imgshowmaxspeed.fillAmount -= 0.01f;
            if (i==95)
            {
                effctpaler.GetComponent<BollEffcts>().Close();

            }
            _Showloaddelay.text = ((int)( _imgshowmaxspeed.fillAmount * 100)).ToString() + "%";
            if (Playermuving.isplay ==false)
            {
                break;
            }
           
        }
       
        StartCoroutine(camerafile());

        maxspeedojectanimator.GetComponent<Animator>().SetInteger("value", 3); ;
        // Playermuving.player.gameObject.GetComponent<Animator>().SetBool("maxspeed", false);
        player.GetComponent<Animator>().SetBool("maxspeed", false);
        Playermuving.speedmuving = Playermuving.speedmuving / 2;
        if (Playermuving.speedmuving <15)
        {
            Playermuving.speedmuving = 15;
        }
        _imgshowmaxspeed.fillAmount = 0;
        _Showloaddelay.text = ((int)(_imgshowmaxspeed.fillAmount * 100)).ToString() + "%";
        Makesupway.makemap.StartCoroutine(Makesupway.makemap.MuvingbackAllemtyWenhaveitemVan(true));
        IntheuseingItem = false;
        _showmaxspeed.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(3f);
        maxspeedojectanimator.GetComponent<Animator>().enabled = false;

        _showmaxspeed.SetActive(false);
        _showmaxspeed.GetComponent<BoxCollider>().enabled = true;

    }
    IEnumerator camerafile()
    {
        if (Camera.main.fieldOfView ==75)
        {
            for (int i = 0; i < 25; i++)
            {
                yield return new WaitForSeconds(0.05f);

                BollEffcts.instance.gameObject.GetComponent<AudioSource>().pitch += 0.1f;
                Camera.main.fieldOfView += 1;
            }
        }
        else if (Camera.main.fieldOfView == 100)
        {
            for (int i = 0; i < 25; i++)
            {
                BollEffcts.instance.gameObject.GetComponent<AudioSource>().pitch -= 0.1f;

                yield return new WaitForSeconds(0.05f);
                Camera.main.fieldOfView -= 1;
            }
        }
       
    }
    private Vector2 WorldToCanvasPosition(RectTransform canvas, Camera camera, Vector3 position)
    {
        //Vector position (percentage from 0 to 1) considering camera size.
        //For example (0,0) is lower left, middle is (0.5,0.5)
        Vector2 temp = camera.WorldToViewportPoint(position);

        //Calculate position considering our percentage, using our canvas size
        //So if canvas size is (1100,500), and percentage is (0.5,0.5), current value will be (550,250)
        temp.x *= canvas.sizeDelta.x;
        temp.y *= canvas.sizeDelta.y;

        //The result is ready, but, this result is correct if canvas recttransform pivot is 0,0 - left lower corner.
        //But in reality its middle (0.5,0.5) by default, so we remove the amount considering cavnas rectransform pivot.
        //We could multiply with constant 0.5, but we will actually read the value, so if custom rect transform is passed(with custom pivot) , 
        //returned value will still be correct.

        temp.x -= canvas.sizeDelta.x * canvas.pivot.x;
        temp.y -= canvas.sizeDelta.y * canvas.pivot.y;

        return temp;
    }
    public Image imgposition;
    public RectTransform rectranform;
    void Update()
    {
        if (Playermuving.isplay)
        {
            imgposition.transform.position = WorldToCanvasPosition(rectranform, Camera.main, Playermuving.player.transform.position);
            imgposition.transform.position = new Vector2(imgposition.transform.position.x + Screen.width / 2, imgposition.transform.position.y + Screen.height / 2);
        }

    }
}
 
