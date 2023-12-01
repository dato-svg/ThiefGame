using System.Collections;
using UnityEngine;

public class EnemyStart : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    [SerializeField] private GameObject SleepEnemy;
    [SerializeField] private GameObject AiWakeUp;

    private bool cheka = true;

    private void Start()
    {
        Enemy.SetActive(false);
        AiWakeUp.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<controlplay>() != null)
        {   if(cheka)
            {
                Debug.Log("vizu");
                Enemy.SetActive(true);
                SleepEnemy.SetActive(false);
                StartCoroutine(waitoFF());
                cheka = false;
            }
           
        }
    }


    private IEnumerator waitoFF()
    {
        AiWakeUp.SetActive(true);
        yield return new WaitForSeconds(5);
        AiWakeUp.SetActive(false);
    }
}
