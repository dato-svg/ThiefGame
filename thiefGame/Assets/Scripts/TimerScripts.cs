using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScripts : MonoBehaviour
{
    [SerializeField] private int minutes = 1;
    [SerializeField] private int seconds = 60;
    [SerializeField] private GameObject PanelGameOver;

    [SerializeField] private TextMeshProUGUI Minutes;
    [SerializeField] private TextMeshProUGUI Secondaries;
    private float timer = 0f;


    private void Start()
    {
        Minutes.text = minutes.ToString();
        Secondaries.text = seconds.ToString();
        PanelGameOver.SetActive(false);


    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer -= 1f;

            if (seconds > 0)
            {
                seconds--;
                Secondaries.text = seconds.ToString();
            }
            else if (minutes > 0)
            {
                minutes--;
                Minutes.text = minutes.ToString();
                seconds = 59;
                Secondaries.text = seconds.ToString();
            }
            else
            {
                PanelGameOver.SetActive(true);
                gameObject.SetActive(false);
                Debug.Log("Time's up!");
            }

          
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        
        Debug.Log(string.Format("{0:00}:{1:00}", minutes, seconds));
    }
}
