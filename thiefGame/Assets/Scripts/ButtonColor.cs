using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    private Image _image;
    [SerializeField] private float R_First;
    [SerializeField] private float G_First;
    [SerializeField] private float B_First;
    [Space(20)]
    [SerializeField] private float R_Last;
    [SerializeField] private float G_Last;
    [SerializeField] private float B_Last;

    private void Start()
    {
        _image = GetComponent<Image>();
    }
    public void ChangeColorSellect()
    {
        _image.color = new Color(R_First / 255, G_First / 255, B_First / 255);
    }

    public void ChangeColorDecellect()
    {
        _image.color = new Color(R_Last / 255, G_Last/ 255, B_Last/ 255);
    }
}
