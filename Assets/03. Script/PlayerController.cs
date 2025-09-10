using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;



    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xspeed = xInput * speed;
        float zspeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xspeed, 0f, zspeed);
        playerRigidbody.linearVelocity = newVelocity;

    }

    public void Die()
    {
        gameObject.SetActive(false);

       
    }
}
