using System.Collections.Generic;
using UnityEngine;

public class ForAI : MonoBehaviour
{
    public List<Transform> positionForBot;
    [SerializeField] private Transform FirstPoint;
    public float Speed = 10;
    public float Distance;
    public LayerMask LayerMask;
    private Transform thisBot;
    private int currentIndex;
    private float waiter = 0;
    private bool ChekOne = true;
    private Animator anim;
    [SerializeField] private GameObject PanelGameOver;
    [SerializeField] private GameObject txt1;
    [SerializeField] private GameObject txt2;
    [SerializeField] private GameObject txt3;
    private void Start()
    {
        currentIndex = 0;
        thisBot = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
       
        if (currentIndex >= positionForBot.Count)
        {
            currentIndex = 0;
        }

        Vector2 targetPosition = positionForBot[currentIndex].position;
        Debug.DrawRay(thisBot.position, (targetPosition - (Vector2)thisBot.position).normalized * Distance, Color.red);

        if (thisBot.position.x < targetPosition.x)
        {
            thisBot.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            thisBot.localScale = new Vector3(-1, 1, 1);
        }

        thisBot.position = Vector2.MoveTowards(thisBot.position, targetPosition, Speed * Time.deltaTime);
        anim.SetBool("Move",true);

        if (Vector2.Distance(thisBot.position, targetPosition) < 0.1f)
        {
            anim.SetBool("Move", false);
            waiter += Time.deltaTime;
            if (waiter > 1)
            {
               
                if (ChekOne)
                {
                    ChekOne = false;
                    positionForBot.Remove(FirstPoint);
                }
                currentIndex++;
                waiter = 0;
               
            }
        }

        
        RaycastHit2D[] hits = Physics2D.RaycastAll(thisBot.position, targetPosition - (Vector2)thisBot.position, Distance, LayerMask);
        foreach (var hit in hits)
        {
            if (hit.collider.CompareTag("Player"))
            {
               
                PanelGameOver.SetActive(true);
                gameObject.SetActive(false);
                hit.collider.gameObject.SetActive(false);
                txt1.SetActive(false);
                txt2.SetActive(false);
                txt3.SetActive(false);
            }
        }
    }
}
