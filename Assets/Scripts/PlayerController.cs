using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Vector2 moveInput;                          //Stores player movement vector
    Rigidbody2D player_rb;
    public Animator player_Animator;

    public ContactFilter2D contactFilter;
    List<RaycastHit2D> raycastList = new List<RaycastHit2D>();
    public float rayDistance = 0.05f;
    public float moveSpeed = 1.0f;
    public Button shopButton;
    public TextMeshProUGUI player_money;

    void Start()
    {
        player_rb= GetComponent<Rigidbody2D>();
        shopButton.gameObject.SetActive(false);
        player_money.text = "0";
    }

    void FixedUpdate()
    {
        player_Animator.SetFloat("MOVE_HORIZ", moveInput.x);
        player_Animator.SetFloat("MOVE_VERT", moveInput.y);
        player_Animator.SetFloat("SPEED", moveInput.sqrMagnitude);

        if (moveInput != Vector2.zero)
        {
            bool moveSuccess = tryToMove(moveInput);

            player_Animator.SetFloat("IDLE_HORIZ", moveInput.x);
            player_Animator.SetFloat("IDLE_VERT", moveInput.y);

            if (!moveSuccess)
            {
                moveSuccess = tryToMove(new Vector2(moveInput.x, 0));

                if (!moveSuccess)
                {
                    moveSuccess = tryToMove(new Vector2(0,moveInput.y));
                }
            }
        }

        }

    private bool tryToMove(Vector2 directionToMove)
    {

        int raycastCount = player_rb.Cast(directionToMove, //Direction to cast the ray
                contactFilter, //Filter for the possible contacts
                raycastList, // List of hits
                rayDistance * moveSpeed * Time.fixedDeltaTime); // lenght of the ray

        Debug.DrawRay(transform.position, directionToMove * 10, Color.white);

        if (raycastCount == 0)
        {
            player_rb.MovePosition(player_rb.position + directionToMove * moveSpeed * Time.fixedDeltaTime);
            return true;
        }
        else return false;

    }

    void OnMove(InputValue directionOfMovement)
    {
        moveInput = directionOfMovement.Get<Vector2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            shopButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC"))
        {
            shopButton.gameObject.SetActive(false);
        }
    }
}
