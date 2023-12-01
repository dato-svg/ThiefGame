using UnityEngine;
using CrazyGames;
public class OnCrazySdkControl : MonoBehaviour
{
   
    void Start()
    {
        CrazyAds.Instance.beginAdBreak();
    }

    

    public void ReklamStart()
    {
        CrazyAds.Instance.beginAdBreakRewarded();
    }
}
