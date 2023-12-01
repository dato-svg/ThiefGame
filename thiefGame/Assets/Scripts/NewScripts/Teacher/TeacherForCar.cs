using UnityEngine;

public class TeacherForCar : MonoBehaviour
{
    public TeacherController tage;
    public bool InCarTrue = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(collision.gameObject);
            tage.InCar.SetActive(false);
            InCarTrue = true;
        }
    }
}
