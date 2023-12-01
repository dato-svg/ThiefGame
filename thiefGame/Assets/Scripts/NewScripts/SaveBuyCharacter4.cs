using UnityEngine;

public class SaveBuyCharacter4 : MonoBehaviour
{

    [SerializeField] private GameObject Buy;
    [SerializeField] private GameObject Sellect;
    [SerializeField] private AudioSource buy;
    [SerializeField] private AudioSource CantBuy;

    private int CountBuy4 = 0;

    private void Awake()
    {
        CountBuy4 = PlayerPrefs.GetInt("SaveCountBuy4000", 0);
    }

    private void Start()
    {
        if (CountBuy4 == 0)
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


    public void BuyCharacter4()
    {
        if (CountBuy4 == 0)
        {   if (PlayerUI.Money >= 10000)
            {
                buy.Play();
                PlayerUI.Money -= 10000;
                Buy.SetActive(false);
                Sellect.SetActive(true);
                CountBuy4++;
                PlayerPrefs.SetInt("SaveCountBuy4000", CountBuy4);
                ManagerShop.CharachterInfo = 4;
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
            ManagerShop.CharachterInfo = 4;
            PlayerPrefs.SetInt("SaveCharacter2", ManagerShop.CharachterInfo);
            buy.Play();
        }

    }
}
