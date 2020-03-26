using Firebase.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginHandler : MonoBehaviour
{

    public Text emailText;
    public Text passwordText;

    private string logText = "";

    Firebase.DependencyStatus dependencyStatus = Firebase.DependencyStatus.UnavailableOther;

    // Start is called before the first frame update
    void Start()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task => {
            dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                SessionHandler.InitializeFirebase(this);
            }
            else
            {
                Debug.LogError(
                  "Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }

    public void CrearUsuarioPorEmail()
    {
        SessionHandler.CreateUserWithEmail(emailText.text, passwordText.text);
    }

    public void Login()
    {
        SessionHandler.LoginByEmail(emailText.text, passwordText.text);
    }
}
