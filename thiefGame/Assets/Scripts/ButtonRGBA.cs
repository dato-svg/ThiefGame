using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public class ButtonRGBA : MonoBehaviour
{
    private Image _image;


    private void Start()
    {
        _image = GetComponent<Image>();
    }

    public void ColorChangerSelect()
    {

        _image.color = new Color(0.5f, 0.5f, 0.5f, 1.0f);
    }

    public void ColorChangerDeselect()
    {
        
        _image.color = new Color(63f / 255f, 61f / 255f, 61f / 255f, 1f);
    }


    public void SaveButton()
    {
        
        PlayerUI.Money += 500;
        PlayerPrefs.SetInt("SaveMoney", PlayerUI.Money);
        PlayerPrefs.Save(); 
        Debug.Log("Money saved: " + PlayerUI.Money);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void ShowReklam()
    {
        RewardContrroler.CanShowReward = false;
        YandexGame.RewVideoShow(0);
    }

    public void LooseButton()
    {
        RewardContrroler.CanShowReward = true;
        PlayerPrefs.SetInt("SaveMoney", PlayerUI.Money);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
