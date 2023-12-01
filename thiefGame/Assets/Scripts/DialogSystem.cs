using UnityEngine;
using System.Collections;
using TMPro;
using System.Collections.Generic;


public class DialogSystem : MonoBehaviour
{
    public string Line;
    public float Speed;
    private AudioSource AudioSource;
    public TextMeshProUGUI textMeshPro;

    private Queue<char> charQueue;

    private void Awake()
    {
        charQueue = new Queue<char>();
        AudioSource = GetComponent<AudioSource>();
        
    }

    private void Start()
    {
        
        Line = textMeshPro.text;
        textMeshPro.text = string.Empty;
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        

        for (int i = 0; i < Line.Length; i++)
        {
            charQueue.Enqueue(Line[i]);

            AudioSource.Play();
            textMeshPro.text = new string(charQueue.ToArray());

            
            yield return new WaitForSeconds(Speed);
        }

        yield return new WaitForSeconds(1);

        textMeshPro.text = string.Empty;
    }
}
