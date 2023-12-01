using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ClickShop()
    {
        SceneManager.LoadScene(2);
    }

    public void ClickPlay()
    {
        SceneManager.LoadScene(1);
    }
}
