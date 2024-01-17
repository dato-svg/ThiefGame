using CrazyGames;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        PlayerUI.Money *= 2;
        PlayerPrefs.SetInt("SaveMoney", PlayerUI.Money);
        
        PlayerPrefs.Save(); 
        Debug.Log("Money saved: " + PlayerUI.Money);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

 public void ReklamShowAll()
    {
        CrazyAds.Instance.beginAdBreakRewarded(SaveButton, Error);
    }

    private void Error()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
