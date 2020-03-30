using Firebase.Auth;

public static class Session
{

    public static FirebaseUser user;
    public static FirebaseAuth loginAuth;

    public static void SetUser(FirebaseUser currentUser)
    {
        user = currentUser;
    }

    public static FirebaseUser GetUser()
    {
        return user;
    }
    public static void SetAuth(FirebaseAuth currentLoginAuthr)
    {
        loginAuth = currentLoginAuthr;
    }

    public static FirebaseAuth GetAuthr()
    {
        return loginAuth;
    }
}
