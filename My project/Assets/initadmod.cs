/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;
//using admob;
public class initadmod : MonoBehaviour {
//    public static initadmod instance;
    // Use this for initialization
    void Start () {
 //       instance = this;
        Debug.Log("start unity demo-------------");
 //        initAdmob();
	}
    public string baner_Adr;
    public string fullbaner_Adr;
   
    public string baner_IOS ;
    public string fullbaner_IOS  ;
  
   // Admob ad;
    //bool isAdmobInited = false;
    void initAdmob()
    {
        string adUnitIdbaner  ;
        string adUnitIdfull ;
        //  isAdmobInited = true;
#if UNITY_EDITOR
          adUnitIdbaner = "baner_Adr";
             adUnitIdfull = "fullbaner_Adr";
#elif UNITY_ANDROID
              adUnitIdbaner = baner_Adr;
              adUnitIdfull = fullbaner_Adr;
#elif UNITY_5 || UNITY_IOS || UNITY_IPHONE
               adUnitIdbaner = baner_IOS;
               adUnitIdfull = fullbaner_IOS;
#else
                adUnitIdbaner = baner_Adr;
               adUnitIdfull = fullbaner_Adr;
#endif

       
        //ad = Admob.Instance();
        //    ad.bannerEventHandler += onBannerEvent;
        //    ad.interstitialEventHandler += onInterstitialEvent;
        //    ad.rewardedVideoEventHandler += onRewardedVideoEvent;
        //    ad.nativeBannerEventHandler += onNativeBannerEvent;
        //    ad.initAdmob(adUnitIdbaner, adUnitIdfull);
            //   ad.setTesting(true);
            Debug.Log("admob inited -------------");
        
    }
    public bool ShowBanerOnPlay;
    public bool _ShowFullOnBackToMainMenu;
    public bool _ShowFullNowOnOpenGame;
    public int ShowFullOndie;

    /// <summary>
    ///  hiện baner nhỏ góc trên màn hình lúc chạy
    /// </summary>
    public void ShowBanerOnPlayGame()
    {
        if (ShowBanerOnPlay)
        {
            ShowBaner();
        }
    }
    /// <summary>
    /// hiện baner lúc chết
    /// sau Showfullondie số lần chết mới cho hiện
    /// </summary>
    public void ShowFullOnDie()
    {
        if (UImanager.uimanager.showbane >= ShowFullOndie-1)
        {
            showInterstitial();
            UImanager.uimanager.showbane = 0;
        }
    }
    /// <summary>
    /// hiện qc khi đến menu chính
    /// </summary>
    public void ShowFullOnBackToMainMenu()
    {
        if (_ShowFullOnBackToMainMenu)
        {
            showInterstitial();
        }
    }
    /// <summary>
    /// hiện quảng cáo khi mới mở game ra khi hết mục dowload
    /// </summary>
    public void ShowFullNowOnOpenGame()
    {
        if (_ShowFullNowOnOpenGame)
        {
            showInterstitial();
        }
    }
    void showInterstitial()
    {
        //if (ad.isInterstitialReady())
        //{
        //    ad.showInterstitial();
        //}
        //else
        //{
        //    ad.loadInterstitial();
        //}
    }
     void ShowBaner()
    {
      //  Admob.Instance().showBannerRelative(AdSize.SmartBanner, AdPosition.TOP_CENTER, 0);
    }

  public    void HideBaner()
    {
       // Admob.Instance().removeBanner();
    }
 
    //void onInterstitialEvent(string eventName, string msg)
    //{
    //    Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
    //    if (eventName == AdmobEvent.onAdLoaded)
    //    {
    //        Admob.Instance().showInterstitial();
    //    }
    //}
    //void onBannerEvent(string eventName, string msg)
    //{
    //    Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
    //}
    //void onRewardedVideoEvent(string eventName, string msg)
    //{
    //    Debug.Log("handler onRewardedVideoEvent---" + eventName + "   " + msg);
    //}
    //void onNativeBannerEvent(string eventName, string msg)
    //{
    //    Debug.Log("handler onAdmobNativeBannerEvent---" + eventName + "   " + msg);
    //}
}
