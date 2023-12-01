using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWinPanel : MonoBehaviour
{
    [SerializeField] private GameObject ower;

    private void Start()
    {
        StartCoroutine(gg());
    }

    private IEnumerator gg()
    {
        yield return new WaitForSeconds(119);
        ower.SetActive(true);

    }
}
