using System.Collections;
using UnityEngine;

public class ForStars : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine(WaitStarOff());
    }


    private IEnumerator WaitStarOff()
    {   while (true)
        {


            yield return new WaitForSeconds(Random.Range(0.2f, 2f));
            _spriteRenderer.enabled = false;
            yield return new WaitForSeconds(1);
            _spriteRenderer.enabled = true;
        }

    }

}
