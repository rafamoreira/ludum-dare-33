using UnityEngine;

static class Grid
{
    public static GameManager gameManager;
    
    static Grid()
    {
        GameObject g;

        g = safeFind("GameManager");
        gameManager = (GameManager)SafeComponent(g, "GameManager");

        
        
        // PS. annoying arcane technical note - remember that really, in c# static constructors do not run
        // until the FIRST TIME YOU USE THEM.  almost certainly in any large project like this, Grid
        // would be called zillions of times by all the Awake (etc etc) code everywhere, so it is
        // a non-issue. but if you're just testing or something, it may be confusing that (for example)
        // the wake-up alert only appears just before you happen to use Grid, rather than "when you hit play"
        // you may want to call "SayHello" from the GeneralOperations.cs, just to decisively start this script.
    }


    // SayHello() has no purpose other than for developers wondering HTF you use Grid.
    // just type Grid.SayHello() anywhere in the project.
    // it is useful to add a similar routine to (example) ExpertiseSystem.cs
    // then from anywhere in the project, you can type Grid.expertiseSystem.SayHello()
    // to check everything is hooked-up properly.
    public static void SayHello()
    {
        Debug.Log("Confirming to developer that the Grid is working fine.");
    }

    // when Grid wakes up, it checks everything is in place - it uses these routines to do so
    private static GameObject safeFind(string s)
    {
        GameObject g = GameObject.Find(s);
        if (g == null) BigProblem("The " + s + " game object is not in this scene. You're stuffed.");
        return g;
    }
    private static Component SafeComponent(GameObject g, string s)
    {
        Component c = g.GetComponent(s);
        if (c == null) BigProblem("The " + s + " component is not there. You're stuffed.");
        return c;
    }
    private static void BigProblem(string error)
    {
        for (int i = 10; i > 0; --i) Debug.LogError(" >>>>>>>>>>>> Cannot proceed... " + error);
        for (int i = 10; i > 0; --i) Debug.LogError(" !!! Is it possible you just forgot to launch from scene zero, the __preEverythingScene scene.");
        Debug.Break();
    }
}

//////////////////////////////////////////////////////////////////////////////