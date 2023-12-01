using UnityEngine;

public class SaveBuyCharacter3 : MonoBehaviour
{
    [SerializeField] private GameObject Buy;
    [SerializeField] private GameObject Sellect;
    [SerializeField] private AudioSource buy;
    [SerializeField] private AudioSource CantBuy;

    private int CountBuy3 = 0;

    private void Awake()
    {
        CountBuy3 = PlayerPrefs.GetInt("SaveCountBuy3000", 0);
    }

    private void Start()
    {
        if (CountBuy3 == 0)
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


    public void BuyCharacter3()
    {
        if (CountBuy3 == 0)
        {   if (PlayerUI.Money >= 5000)
            {
                buy.Play();
                PlayerUI.Money -= 5000;
                Buy.SetActive(false);
                Sellect.SetActive(true);
                CountBuy3++;
                PlayerPrefs.SetInt("SaveCountBuy3000", CountBuy3);
                ManagerShop.CharachterInfo = 3;
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
            ManagerShop.CharachterInfo = 3;
            PlayerPrefs.SetInt("SaveCharacter2", ManagerShop.CharachterInfo);
            buy.Play();
        }

    }
}
