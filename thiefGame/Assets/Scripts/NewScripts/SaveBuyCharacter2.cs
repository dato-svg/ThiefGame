using UnityEngine;

public class SaveBuyCharacter2 : MonoBehaviour
{
    [SerializeField] private GameObject Buy;
    [SerializeField] private GameObject Sellect;
    [SerializeField] private AudioSource buy;
    [SerializeField] private AudioSource CantBuy;

    private int CountBuy2 = 0;

    private void Awake()
    {
        CountBuy2 = PlayerPrefs.GetInt("SaveCountBuy2000", 0);
    }

    private void Start()
    {
        if (CountBuy2 == 0)
        {
            Buy.SetActive(true);
            Sellect.SetActive(false);
        }
        else
        {
            Buy.SetActive(false);
            Sellect.SetActive(true);
        }
    }


    public void BuyCharacter2()
    {
        if (CountBuy2 == 0)
        {   if (PlayerUI.Money >= 2000)
            {
                buy.Play();
                PlayerUI.Money -= 2000;
                Buy.SetActive(false);
                Sellect.SetActive(true);
                CountBuy2++;
                PlayerPrefs.SetInt("SaveCountBuy2000", CountBuy2);
                ManagerShop.CharachterInfo = 2;
                PlayerPrefs.SetInt("SaveCharacter2", ManagerShop.CharachterInfo);
                PlayerPrefs.SetInt("SaveMoney", PlayerUI.Money);
            }
        else
            {
                CantBuy.Play();
            }
        }
        else
        {
            ManagerShop.CharachterInfo = 2;
            PlayerPrefs.SetInt("SaveCharacter2", ManagerShop.CharachterInfo);
            buy.Play();
        }

    }
}
