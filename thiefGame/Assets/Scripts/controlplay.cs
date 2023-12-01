using System.Collections;
using UnityEngine;

public class controlplay : MonoBehaviour
{
    [SerializeField] private GameObject PersonSprite;
    [SerializeField] private GameObject LeftHend;
    [SerializeField] private GameObject RightHand;

    [Space(15)]
    [SerializeField] private HingeJoint2D joint;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float JumpSpeed = 5f;
    [Space(12)]
    [SerializeField] private float DistanceJump = 1f;
    [SerializeField] private float DistanceInteracte = 1f;
    [Space(12)]
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private LayerMask layerMaskThachable;
    [Space(12)]
    [SerializeField] private Transform RayPosition;
    private Rigidbody2D rb;
    private Vector2 interactDirection;
    private PlayerUI playerUI;
    [SerializeField] private GameObject ShopPriceObject;
    private float currectTimer = 0;
    private BoxCollider2D boxcool;
    private bool JumpCheker = true;
   

    [Space(15)]
    [SerializeField] private AudioSource Jump;
    [SerializeField] private AudioSource Take;



    private void Awake()
    {
        PlayerUI.Money = PlayerPrefs.GetInt("SaveMoney", 0);
        rb = GetComponent<Rigidbody2D>();
        joint = GetComponent<HingeJoint2D>();
        joint.connectedBody = rb;
        playerUI = GetComponent<PlayerUI>();
        ShopPriceObject.SetActive(false);
        boxcool = GetComponent<BoxCollider2D>();
        PlayerUI.Money = PlayerPrefs.GetInt("SaveMoney", 0);
        Debug.Log("Money saved: " + PlayerUI.Money);
        if (playerUI != null)
        {
            playerUI.ShowcurrectMoney();
        }
        

    }
    private bool TryJump()
    {
        return Physics2D.BoxCast(boxcool.bounds.center, boxcool.bounds.size, 0, Vector2.down, DistanceJump, layerMaskThachable);
    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.blue;
        Gizmos.DrawCube(boxcool.bounds.center, boxcool.bounds.size * DistanceJump);


        Gizmos.color = Color.green;
        Gizmos.DrawCube(boxcool.bounds.center, boxcool.bounds.size * DistanceInteracte);



    }


    private void Update()
    {
        PlayerPrefs.SetInt("SaveMoney", PlayerUI.Money);

        PersonSprite.GetComponent<Animator>().SetBool("Move", false);
        Debug.DrawRay(RayPosition.position, interactDirection * DistanceInteracte, Color.blue);
        if (Input.GetKey(KeyCode.A))
        {
            PersonSprite.GetComponent<Animator>().SetBool("Move", true);
            PersonSprite.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            rb.AddForce(Vector2.left * speed * Time.deltaTime);
            interactDirection = -transform.right;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(Vector2.left * speed * 0.8f * Time.deltaTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.W) && TryJump() && JumpCheker)
        {
            StartCoroutine(WaitJump());
            Debug.Log("Jump");
        }

        if (Input.GetKey(KeyCode.D))
        {
            PersonSprite.GetComponent<Animator>().SetBool("Move", true);
            PersonSprite.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
            rb.AddForce(Vector2.right * speed * Time.deltaTime);
            interactDirection = transform.right;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(Vector2.right * speed * 0.8f * Time.deltaTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.BoxCast(boxcool.bounds.center, boxcool.bounds.size, 0, interactDirection, DistanceInteracte, layerMaskThachable);

            if (hit.collider != null)
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    ShopPriceObject.SetActive(true);
                    Take.Play();
                    Debug.Log(interactable.PriceText);
                    joint.connectedBody = interactable.GetComponent<Rigidbody2D>();
                    JumpSpeed += 5;
                    if (playerUI != null)
                    {
                        playerUI.ShowPrice(interactable.PriceText);
                    }
                    currectTimer = 0;

                    if (LeftHend.transform.position.x < interactable.transform.position.x)
                    {
                        LeftHend.transform.eulerAngles = new Vector3(0f, 0f, 25.18f);
                    }
                    else
                    {
                        LeftHend.transform.eulerAngles = new Vector3(0f, 0f, -25.18f);
                    }

                    if (RightHand.transform.position.x < interactable.transform.position.x)
                    {
                        RightHand.transform.eulerAngles = new Vector3(0f, 0f, 30.05f);
                    }
                    else
                    {
                        RightHand.transform.eulerAngles = new Vector3(0f, 0f, -30.05f);
                    }
                }
            }
        }

        currectTimer += Time.deltaTime;
        if (currectTimer > 1.2f)
        {
            ShopPriceObject.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            joint.connectedBody = rb;
            ShopPriceObject.SetActive(false);
            JumpSpeed = 20;
            LeftHend.transform.eulerAngles = new Vector3(0f, 0f, -15.18f);
            RightHand.transform.eulerAngles = new Vector3(0f, 0f, -23.05f);
        }
    }

    private void Jumpi()
    {
        rb.AddForce(Vector2.up * JumpSpeed, ForceMode2D.Impulse);
        Jump.Play();
    }


    private IEnumerator WaitJump()
    {

        Jumpi();
        JumpCheker = false;
        yield return new WaitForSeconds(0.3f);
        JumpCheker = true;
    }





}
