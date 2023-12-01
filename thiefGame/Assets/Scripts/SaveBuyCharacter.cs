using UnityEngine;

public class SaveBuyCharacter : MonoBehaviour
{
    [SerializeField] private GameObject Buy;
    [SerializeField] private GameObject Sellect;
    [SerializeField] private AudioSource buy;
    [SerializeField] private AudioSource CantBuy;

    private int CountBuy = 0;

    private void Awake()
    {
        CountBuy = PlayerPrefs.GetInt("SaveCountBuy500", 0);
    }

    private void Start()
    {
        if(CountBuy == 0)
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
    

    public void BuyCharacter()
    {   if(CountBuy == 0)
        {   if (PlayerUI.Money >=1000)
            {
                buy.Play();
                PlayerUI.Money -= 1000;
                Buy.SetActive(false);
                Sellect.SetActive(true);
                CountBuy++;
                PlayerPrefs.SetInt("SaveCountBuy500", CountBuy);
                ManagerShop.CharachterInfo = 1;
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
            ManagerShop.CharachterInfo = 1;
            PlayerPrefs.SetInt("SaveCharacter2", ManagerShop.CharachterInfo);
            buy.Play();
        }
        
    }
}
