using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LogoScene : MonoBehaviour
{
    /*private VideoPlayer player;
    public string url;

    private void Awake()
    {
        player = GetComponent<VideoPlayer>();
        player.url = url;
    }*/

    private void Start()
    {
        
        StartCoroutine(NewSceneLogo());
    }


    private IEnumerator NewSceneLogo()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}
