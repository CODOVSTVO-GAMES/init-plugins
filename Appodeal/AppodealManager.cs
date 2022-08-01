using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class AppodealManager : MonoBehaviour, IInterstitialAdListener
{
    private const string APP_KEY = "key";
    private bool _consentValue = true;
    private bool _testMode = false;

    private void Start()
    {
        //Appodeal.setTesting(_testMode);

        //Full-screen ad that engages users with a captivating video
        Appodeal.initialize(APP_KEY, Appodeal.INTERSTITIAL, _consentValue);

        //User-initiated ads where users can earn in-app rewards in exchange for viewing a video ad
        Appodeal.initialize(APP_KEY, Appodeal.REWARDED_VIDEO, _consentValue);

        //Traditional ad format that neatly places a small ad at the top or bottom of the screen
        Appodeal.show(Appodeal.BANNER_BOTTOM);
        Appodeal.show(Appodeal.BANNER_TOP);
        Appodeal.show(Appodeal.BANNER_LEFT);
        Appodeal.show(Appodeal.BANNER_RIGHT);
    }

    public void ShowInterstital()
    {
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
    }

    public void ShowRewardedVideo()
    {
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
        }
    }

    public void ShowBanner(string type)
    {
        switch (type)
        {
            case "bottom":
                Appodeal.show(Appodeal.BANNER_BOTTOM);
                break;
            case "top":
                Appodeal.show(Appodeal.BANNER_TOP);
                break;
            case "left":
                Appodeal.show(Appodeal.BANNER_LEFT);
                break;
            case "right":
                Appodeal.show(Appodeal.BANNER_RIGHT);
                break;
        }
    }

    public void onInterstitialLoaded(bool isPrecache)
    {
        print("Interstitial loaded");
    }

    // Called when interstitial failed to load
    public void onInterstitialFailedToLoad()
    {
        print("Interstitial failed");
    }

    // Called when interstitial was loaded, but cannot be shown (internal network errors, placement settings, or incorrect creative)
    public void onInterstitialShowFailed()
    {
        print("Interstitial show failed");
    }

    // Called when interstitial is shown
    public void onInterstitialShown()
    {
        print("Interstitial opened");
    }

    // Called when interstitial is closed
    public void onInterstitialClosed()
    {
        print("Interstitial closed");
    }

    // Called when interstitial is clicked
    public void onInterstitialClicked()
    {
        print("Interstitial clicked");
    }

    // Called when interstitial is expired and can not be shown
    public void onInterstitialExpired()
    {
        print("Interstitial expired");
    }
}

