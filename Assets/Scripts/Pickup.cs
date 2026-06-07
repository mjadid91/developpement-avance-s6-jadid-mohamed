using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSFX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(
                pickupSFX,
                Camera.main.transform.position
            );

            Destroy(gameObject);
        }
    }
}