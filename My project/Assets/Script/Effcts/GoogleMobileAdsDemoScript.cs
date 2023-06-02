/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using UnityEngine;
//using GoogleMobileAds;
//using GoogleMobileAds.Api;

//public class GoogleMobileAdsDemoHandler : IDefaultInAppPurchaseProcessor
//{
//    private readonly string[] validSkus = { "android.test.purchased" };

//    //Will only be sent on a success.
//    public void ProcessCompletedInAppPurchase(IInAppPurchaseResult result)
//    {
//        result.FinishPurchase();
//        GoogleMobileAdsDemoScript.OutputMessage = "Purchase Succeeded! Credit user here.";
//    }

//    //Check SKU against valid SKUs.
//    public bool IsValidPurchase(string sku)
//    {
//        foreach(string validSku in validSkus)
//        {
//            if (sku == validSku)
//            {
//                return true;
//            }
//        }
//        return false;
//    }

//    //Return the app's public key.
//    public string AndroidPublicKey
//    {
//        //In a real app, return public key instead of null.
//        get { return null; }
//    }
//}

// Example script showing how to invoke the Google Mobile Ads Unity plugin.
public class GoogleMobileAdsDemoScript : MonoBehaviour
{

    //private BannerView bannerView;
    //private InterstitialAd interstitial;
    //private RewardBasedVideoAd rewardBasedVideo;
    private float deltaTime = 0.0f;
    private static string outputMessage = "";

    public static string OutputMessage
    {
        set { outputMessage = value; }
    }

    void Start()
    {
        // Get singleton reward based video ad reference.
        //rewardBasedVideo = RewardBasedVideoAd.Instance;

        //// RewardBasedVideoAd is a singleton, so handlers should only be registered once.
        //rewardBasedVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
        //rewardBasedVideo.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
        //rewardBasedVideo.OnAdOpening += HandleRewardBasedVideoOpened;
        //rewardBasedVideo.OnAdStarted += HandleRewardBasedVideoStarted;
        //rewardBasedVideo.OnAdRewarded += HandleRewardBasedVideoRewarded;
        //rewardBasedVideo.OnAdClosed += HandleRewardBasedVideoClosed;
        //rewardBasedVideo.OnAdLeavingApplication += HandleRewardBasedVideoLeftApplication;
    }

    void Update()
    {
        // Calculate simple moving average for time to render screen. 0.1 factor used as smoothing
        // value.
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    
    private void RequestBanner()
    {
        #if UNITY_EDITOR
            string adUnitId = "unused";
#elif UNITY_ANDROID
            string adUnitId = "ca-app-pub-9103273420287482/5789481251";
#elif UNITY_IPHONE
            string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        //bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top);
        //// Register for ad events.
        //bannerView.OnAdLoaded += HandleAdLoaded;
        //bannerView.OnAdFailedToLoad += HandleAdFailedToLoad;
        //bannerView.OnAdLoaded += HandleAdOpened;
        //bannerView.OnAdClosed += HandleAdClosed;
        //bannerView.OnAdLeavingApplication += HandleAdLeftApplication;
        //// Load a banner ad.
        //bannerView.LoadAd(createAdRequest());
    }

    private void RequestInterstitial()
    {
        #if UNITY_EDITOR
            string adUnitId = "unused";
#elif UNITY_ANDROID
            string adUnitId = "ca-app-pub-9103273420287482/3614744052";
#elif UNITY_IPHONE
            string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create an interstitial.
        //interstitial = new InterstitialAd(adUnitId);
        //// Register for ad events.
        //interstitial.OnAdLoaded += HandleInterstitialLoaded;
        //interstitial.OnAdFailedToLoad += HandleInterstitialFailedToLoad;
        //interstitial.OnAdOpening += HandleInterstitialOpened;
        //interstitial.OnAdClosed += HandleInterstitialClosed;
        //interstitial.OnAdLeavingApplication += HandleInterstitialLeftApplication;
        //// Load an interstitial ad.
        //interstitial.LoadAd(createAdRequest());
    }

    // Returns an ad request with custom ad targeting.
    //private AdRequest createAdRequest()
    //{
    //    return new AdRequest.Builder()
    //            .AddTestDevice(AdRequest.TestDeviceSimulator)
    //            .AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
    //            .AddKeyword("game")
    //            .SetGender(Gender.Male)
    //            .SetBirthday(new DateTime(1985, 1, 1))
    //            .TagForChildDirectedTreatment(false)
    //            .AddExtra("color_bg", "9B30FF")
    //            .Build();
    //}

    //private void RequestRewardBasedVideo()
    //{
    //    #if UNITY_EDITOR
    //        string adUnitId = "unused";
    //    #elif UNITY_ANDROID
    //        string adUnitId = "INSERT_ANDROID_REWARD_BASED_VIDEO_AD_UNIT_ID_HERE";
    //    #elif UNITY_IPHONE
    //        string adUnitId = "INSERT_IOS_REWARD_BASED_VIDEO_AD_UNIT_ID_HERE";
    //    #else
    //        string adUnitId = "unexpected_platform";
    //    #endif

    //    rewardBasedVideo.LoadAd(createAdRequest(), adUnitId);
    //}

    //private void ShowInterstitial()
    //{
    //    if (interstitial.IsLoaded())
    //    {
    //        interstitial.Show();
    //    }
    //    else
    //    {
    //        print("Interstitial is not ready yet.");
    //    }
    //}

    //private void ShowRewardBasedVideo()
    //{
    //    if (rewardBasedVideo.IsLoaded())
    //    {
    //        rewardBasedVideo.Show();
    //    } else
    //    {
    //        print("Reward based video ad is not ready yet.");
    //    }
    //}

 
}
