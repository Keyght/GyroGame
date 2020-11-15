using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;


    public class SvaipCamera : MonoBehaviour
    {
    public float touchRotAdjust = 1f;

    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
       
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Add this part after the other Rotation lines
            transform.Rotate((touchDeltaPosition.x * touchRotAdjust) / 3, 0f, 0f, Space.Self);
        }

    }
}
