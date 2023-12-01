using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI PriceMoneyText;
    public TextMeshProUGUI ScoreMoneyText;
    public TextMeshProUGUI TakeMoneyText;
    public static int Money = 0;

    public void ShowPrice(int _text)
    {
        PriceMoneyText.text = _text.ToString();
    }

    public void ShowTakeMoney(int _text)
    {
        TakeMoneyText.text = _text.ToString();
    }
    public  void ShowcurrectMoney()
    {
        ScoreMoneyText.text = Money.ToString();
    }
}
