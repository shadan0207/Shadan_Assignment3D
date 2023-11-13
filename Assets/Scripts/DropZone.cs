using UnityEngine;

public class DropZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the dragged object is the one you want to place on the plane
        if (other.CompareTag("build"))
        {
            // Place the object on the plane
            other.transform.position = transform.position;


        }
    }
}
