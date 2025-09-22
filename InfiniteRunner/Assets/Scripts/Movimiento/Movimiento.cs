using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Player Settings")]
    public float jumpForce = 8f; // Fuerza del salto
    public float secondJumpForce = 2f;
    public float crouchScale = 0.5f; // Tamaño del jugador al agacharse
    public float crouchDuration = 0.5f; // Duración de la animación de agacharse

    private Rigidbody rb;
    private Vector3 originalScale;
    private bool isGrounded = true;
    private bool isCrouching = false;
    private bool doubleJump = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalScale = transform.localScale; // Guarda el tamaño original
    }

    void Update()
    {
        // Saltar
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || doubleJump))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
                       

            if (!isGrounded) 
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                doubleJump = false;
            }

            isGrounded = false;
        }

        // Agacharse
        if (Input.GetKeyDown(KeyCode.LeftControl) && !isCrouching)
        {
            StartCoroutine(Crouch());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            doubleJump = true;
        }
    }

    // Corrutina para agacharse y volver a su tamaño normal
    private System.Collections.IEnumerator Crouch()
    {
        isCrouching = true;
        transform.localScale = new Vector3(originalScale.x, originalScale.y * crouchScale, originalScale.z);
        yield return new WaitForSeconds(crouchDuration);
        transform.localScale = originalScale;
        isCrouching = false;
    }
}