using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();

        bulletRigidbody.linearVelocity = transform.forward * speed;

        Destroy(gameObject, 3f);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }


}
