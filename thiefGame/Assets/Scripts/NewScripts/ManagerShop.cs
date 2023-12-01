using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerShop : MonoBehaviour
{
    [SerializeField] private GameObject Head1;
    [SerializeField] private GameObject Head2;
    [SerializeField] private GameObject Head3;
    [SerializeField] private GameObject Head4;

    public static int CharachterInfo = 0;

    private void Awake()
    {
        Head1.SetActive(false);
        Head2.SetActive(false);
        Head3.SetActive(false);
        Head4.SetActive(false);
        CharachterInfo = PlayerPrefs.GetInt("SaveCharacter2",0);

    }
    private void Start()
    {   
        if(CharachterInfo == 1)
        {
            Head1.SetActive(true);
            Head2.SetActive(false);
            Head3.SetActive(false);
            Head4.SetActive(false);
        }

        if (CharachterInfo == 2)
        {
            Head1.SetActive(false);
            Head2.SetActive(true);
            Head3.SetActive(false);
            Head4.SetActive(false);
        }

        if (CharachterInfo == 3)
        {
            Head1.SetActive(false);
            Head2.SetActive(false);
            Head3.SetActive(true);
            Head4.SetActive(false);
        }

        if (CharachterInfo == 4)
        {
            Head1.SetActive(false);
            Head2.SetActive(false);
            Head3.SetActive(false);
            Head4.SetActive(true);
        }
    }
}
