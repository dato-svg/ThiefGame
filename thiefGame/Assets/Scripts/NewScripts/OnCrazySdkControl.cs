using UnityEngine;
using CrazyGames;
using UnityEngine.SceneManagement;

public class OnCrazySdkControl : MonoBehaviour
{
    
    
    void Start()
    {
        if (SDKCrazyGamesController.CanShowReward)
        {
            CrazyAds.Instance.beginAdBreak();
        }
        
       
    }

    

    public void ReklamStart()
    {
        CrazyAds.Instance.beginAdBreakRewarded(SuccessCallback,ErrorCallback);
        SDKCrazyGamesController.CanShowReward = false;
    }

    private void SuccessCallback()
    {
        PlayerUI.Money += 500;
        PlayerPrefs.SetInt("money" ,PlayerUI.Money );
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ErrorCallback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
    public void LooseButton()
    {
        
        PlayerPrefs.SetInt("money", PlayerUI.Money);
        SDKCrazyGamesController.CanShowReward = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
