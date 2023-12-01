using TMPro;
using UnityEngine;

public class ShowMoney : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMoney;

    private void Start()
    {
        PlayerUI.Money =  PlayerPrefs.GetInt("SaveMoney",0);
    }
    void Update()
    {
        _textMoney.text = PlayerUI.Money.ToString();
    }
}
