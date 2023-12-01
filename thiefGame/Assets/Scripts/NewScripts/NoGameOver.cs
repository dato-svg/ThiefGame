using System.Collections;
using UnityEngine;

public class NoGameOver : MonoBehaviour
{
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject PanelOver;


    
    
    private void OnTriggerStay2D(Collider2D collision)
    {   if(collision.gameObject.CompareTag("Player"))
        {
            Player.SetActive(false);
            WinPanel.SetActive(true);
            PanelOver.SetActive(false);
        }
       
    }


   
   
       
        
        

    
}
