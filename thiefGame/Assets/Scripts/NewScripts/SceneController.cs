using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ClickShop()
    {
        SceneManager.LoadScene(3);
    }

    public void ClickPlay()
    {
        SceneManager.LoadScene(2);
    }
}
