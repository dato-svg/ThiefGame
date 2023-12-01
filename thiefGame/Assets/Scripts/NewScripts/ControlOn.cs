using UnityEngine;

public class ControlOn : MonoBehaviour
{
    [SerializeField] private controlplay conta;



    private void Start()
    {
        conta.enabled = true;
    }
}
