using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GoNewScene());
    }

    private IEnumerator GoNewScene()
    {
       yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
