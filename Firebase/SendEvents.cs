using UnityEngine;
using Firebase;
using Firebase.Analytics;

public static class SendEvents
{
    public static void SendEvent(string message)
    {
        //message - your message for the event
        Firebase.Analytics.FirebaseAnalytics.LogEvent(message);
    }
}