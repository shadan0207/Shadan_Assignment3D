using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Unity.UI;

public class DragandDrop : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private bool isDragging = false;
    private RectTransform rectTransform;

    public GameObject build;

    private Image image; // Assuming you are using UnityEngine.UI.Image
    private CanvasGroup canvasGroup; // For handling visibility


    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        canvasGroup = GetComponent<CanvasGroup>();

        image.SetEnabled(false); 
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;

        // Show the image when dragging starts
        image.SetEnabled(true);

        // Disable interaction with the UI element while dragging
        canvasGroup.blocksRaycasts = false;

    }

    /* public void OnPointerUp(PointerEventData eventData)
     {
         isDragging = false;

         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         //Debug.Log("ray started");

         if (Physics.Raycast(ray, out hit))
         {
             if (hit.collider.CompareTag("Ground"))
             {
                  Vector3 newPosition = hit.point;

                 GameObject school = Instantiate(build, newPosition, Quaternion.identity);
             }
         }
     }*/

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                Vector3 newPosition = SnapToGrid(hit.point);
                GameObject school = Instantiate(build, newPosition, Quaternion.identity);

                // Hide the image after placement
                image.SetEnabled(false);

                // Enable interaction with the UI element again
                canvasGroup.blocksRaycasts = true;
            }
        }
    }

    private Vector3 SnapToGrid(Vector3 position)
    {
        // Adjust position to snap to a grid (you can customize the grid size)
        float gridSize = 1.0f;
        position.x = Mathf.Floor(position.x / gridSize) * gridSize + gridSize / 2.0f;
        position.z = Mathf.Floor(position.z / gridSize) * gridSize + gridSize / 2.0f;
        return position;
    }



    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            rectTransform.anchoredPosition += eventData.delta;
        }
    }
}
