using UnityEngine;

public class LookCharacter : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player3;
    [SerializeField] private GameObject player4;


    private void Start()
    {
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(false);
    }

    public void LookCharachter1()
    {
        player1.SetActive(true);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(false);
    }

    public void LookCharachter2()
    {
        player1.SetActive(false);
        player2.SetActive(true);
        player3.SetActive(false);
        player4.SetActive(false);
    }

    public void LookCharachter3()
    {
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(true);
        player4.SetActive(false);
    }

    public void LookCharachter4()
    {
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(true);
    }
}
