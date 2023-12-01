using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public int PriceText;


    public void CallMethod()
    {
        MyWork();
    }

    protected virtual void MyWork()
    {

    }
}
