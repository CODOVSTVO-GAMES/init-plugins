using UnityEngine;
using Firebase;

public class InitFirebase : MonoBehaviour
{
    private DependencyStatus dependencyStatus = DependencyStatus.UnavailableOther;
    private static FirebaseApp DefaultInstance;

    private void Awake()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available) 
            {
                DefaultInstance = Firebase.FirebaseApp.DefaultInstance;
            } 
            else 
            {
                UnityEngine.Debug.LogError(System.String.Format(
                    "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
            }
        });
    }
}

