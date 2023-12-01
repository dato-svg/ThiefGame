using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MoonController : MonoBehaviour
{
    [SerializeField] private GameObject PlayerLighth;
    [SerializeField] private GameObject StarGM;
    [SerializeField] private int LengthOnTime = 100;
    [SerializeField] private float Time1;

    [SerializeField] private GameObject StartTxt;
    [SerializeField] private GameObject Last30Txt;
    private Light2D  DirectionalLight;


    private void Awake()
    {
        DirectionalLight = GetComponent<Light2D>();
    }

    private void Start()
    {
        StartCoroutine(ChangeLightIntensity());
        StartCoroutine(Wait30second());
        
    }

    private IEnumerator ChangeLightIntensity()
    {   
        yield return new WaitForSeconds(LengthOnTime);

        float elapsedTime = 0f;

        while (elapsedTime < Time1)
        {
            float t = elapsedTime / Time1;
            DirectionalLight.intensity = Mathf.Lerp(0.1f, 1, t);
            elapsedTime += Time.deltaTime;
            if(elapsedTime >= Time1)
            {
                PlayerLighth.SetActive(false);
                StarGM.SetActive(false);
            }
            yield return null;
        }

        
    }

    private IEnumerator Wait30second()
    {
        yield return new WaitForSeconds(0.2f);
        StartTxt.SetActive(true);
        yield return new WaitForSeconds(7f);
        StartTxt.SetActive(false);
        yield return new WaitForSeconds(80);
        Last30Txt.SetActive(true);
        yield return new WaitForSeconds(5f);
        Last30Txt.SetActive(false);

    }
}
