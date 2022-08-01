using UnityEngine;
using Firebase;
using Firebase.Analytics;

public static class SendEvents
{
    public static void SendEvent(string type)
    {
        //type - your message for the event
        Firebase.Analytics.FirebaseAnalytics.LogEvent(type);
    }
}