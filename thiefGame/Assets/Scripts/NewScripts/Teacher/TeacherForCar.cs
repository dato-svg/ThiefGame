using UnityEngine;
using UnityEngine.SceneManagement;

public class TeacherForCar : MonoBehaviour
{
    public TeacherController tage;
    public bool InCarTrue = false;
    [SerializeField] private GameObject play;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(collision.gameObject);
            tage.InCar.SetActive(false);
            play.SetActive(true);
            InCarTrue = true;
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
