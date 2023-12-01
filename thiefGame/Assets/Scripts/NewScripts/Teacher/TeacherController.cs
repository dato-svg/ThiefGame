using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeacherController : MonoBehaviour
{
    [SerializeField] private GameObject Abutton;
    [SerializeField] private GameObject Dbutton;
    [SerializeField] private GameObject Wbutton;
    [SerializeField] private GameObject Spacebutton;
    public GameObject InCar;
    public TeacherForCar car;

    private bool A = false;
    private bool D = false;
    private bool W = false;
    private bool In = false;
    private bool Space = false;


    private bool Chake =false;

    private void Start()
    {
        Abutton.SetActive(true);
        Dbutton.SetActive(false);
        Wbutton.SetActive(false);
        Spacebutton.SetActive(false);
        InCar.SetActive(false);
        

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {   if(!A)
            {
                Abutton.SetActive(false);
                Dbutton.SetActive(true);
                Wbutton.SetActive(false);
                Spacebutton.SetActive(false);
                InCar.SetActive(false);
                A = true;
            }
           
        }

        if (Input.GetKeyDown(KeyCode.D))
        {   if(!D && A)
            {
                Abutton.SetActive(false);
                Dbutton.SetActive(false);
                Wbutton.SetActive(true);
                Spacebutton.SetActive(false);
                InCar.SetActive(false);
                D = true;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {   if(!W && A && D)
            {
                Abutton.SetActive(false);
                Dbutton.SetActive(false);
                Wbutton.SetActive(false);
                Spacebutton.SetActive(true);
                InCar.SetActive(false);
                W = true;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!Space && A && D && W && Chake)
            {
                Abutton.SetActive(false);
                Dbutton.SetActive(false);
                Wbutton.SetActive(false);
                Spacebutton.SetActive(false);
                InCar.SetActive(true);
                Space = true;
            }

        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            Chake = true;
        }

        if(collision.gameObject.CompareTag("Door"))
        {
            if(car.InCarTrue)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            StartCoroutine(gg());
        }


    }



    private IEnumerator gg()
    {
        yield return new WaitForSeconds(1);
        Chake = false;
    }


}
