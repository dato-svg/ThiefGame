using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageController : MonoBehaviour
{
    [SerializeField] private GameObject ru;
    [SerializeField] private GameObject end;

    private bool OnOff = true;




    private void Start()
    {
        ru.SetActive(false);
        end.SetActive(false);
    }

    public void ClickOnOff()
    {
        if(OnOff)
        {
            ru.SetActive(true);
            end.SetActive(true);
            OnOff = false;
        }
        else
        {
            ru.SetActive(false);
            end.SetActive(false);
            OnOff = true;
        }
    }
}
