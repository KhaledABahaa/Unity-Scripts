using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRb;
    public InputAction jumpAction;
    public float jumpForce = 10.0f;
    public float gravityModifier;
    public bool onGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    public ParticleSystem playerExplosion;
    public ParticleSystem dirtParticles;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        jumpAction.Enable();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
        playerSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (jumpAction.triggered && onGround && !gameOver)
        {
             playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
             onGround = false;
             playerAnim.SetTrigger("Jump_trig");
             dirtParticles.Stop();
             playerSound.PlayOneShot(jumpSound, 1.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            dirtParticles.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!!");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            playerExplosion.Play();
            dirtParticles.Stop();
            playerSound.PlayOneShot(crashSound, 1.0f);
        }
    }
}
