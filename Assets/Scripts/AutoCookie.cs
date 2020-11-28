using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour {
    
    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalInctrease;

    void Update () {
        CookieIncrease = GlobalBaker.bakePerSec;
        InternalInctrease = CookieIncrease;
        if (CreatingCookie == false) {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }

    IEnumerator CreateTheCookie () {
        GlobalCookies.CookieCount += InternalInctrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
