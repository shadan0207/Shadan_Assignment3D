using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class DragandDrop : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private bool isDragging = false;
    private RectTransform rectTransform;

    public GameObject build;

    public Image image;
    private CanvasGroup canvasGroup; // For handling visibility

    private Vector3 initialPosition;
    private Vector3 offsetPosition; // Added variable to store the offset


    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        canvasGroup = GetComponent<CanvasGroup>();
        initialPosition = rectTransform.position;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;

        // Disable interaction with the UI element while dragging
        canvasGroup.blocksRaycasts = false;
        
        offsetPosition = rectTransform.position - Camera.main.ScreenToWorldPoint(eventData.position);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
        rectTransform.position = initialPosition+ offsetPosition;


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Ground") || hit.collider.CompareTag("Road"))
            {
                Vector3 newPosition = SnapToGrid(hit.point);
                Vector3 offset = new Vector3(0, 0.05f, 0);
                GameObject school = Instantiate(build, newPosition + offset, Quaternion.identity);
                
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
