using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCar : MonoBehaviour
{
    [SerializeField] private PlayerUI playerUI;
    [SerializeField] private GameObject TakeMoneyObj;
    private AudioSource forCarSorce;

    

    private void Awake()
    {
        TakeMoneyObj.SetActive(false);
        forCarSorce = GetComponent<AudioSource>();
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var thachable = collision.gameObject.GetComponent<Thachable>();
        if (thachable != null)
        {
           
            TakeMoneyObj.SetActive(true);
            TakeMoneyObj.GetComponent<Animator>().SetBool("Show",true);
            PlayerUI.Money += thachable.PriceText;
            playerUI.ShowTakeMoney(thachable.PriceText);
            playerUI.ShowcurrectMoney();
            forCarSorce.Play();
            Destroy(collision.gameObject);
        }

       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Thachable>())
        {

            StartCoroutine(WaiterTakeMoney());


        }
    }


    IEnumerator  WaiterTakeMoney()
    {
        yield return new WaitForSeconds(1);
        TakeMoneyObj.SetActive(false);
    }
    
}
