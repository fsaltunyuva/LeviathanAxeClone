using UnityEngine;

public class HorizontalAxeCaller : MonoBehaviour
{
    public float interpolator = 0f;
    private bool comeBack = false;
    private Vector3 startPosition;
    public Vector3 targetPosition; // Hand of Kratos
    public float speed = 1f;
    [SerializeField] private Transform kratosHand;
    
    public float baseSpeed = 1f;
    [SerializeField] private float referenceDistance = 25f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            startPosition = transform.position; // Store the starting position
            interpolator = 0f; // Reset the interpolator to 0
            comeBack = true; // Start the slerp
            Debug.Log("Distance: " + Vector3.Distance(startPosition, targetPosition));
        }

        targetPosition = kratosHand.position; // Get the target position every frame (Kratos' hand position changes because of animations)

        if (comeBack)
        {
            float distance = Vector3.Distance(startPosition, targetPosition);

            // Dynamic speed based on distance
            float dynamicSpeed = baseSpeed * (referenceDistance / distance);
            dynamicSpeed = Mathf.Clamp(dynamicSpeed, baseSpeed, baseSpeed * 5f); // Clamp the speed to a reasonable range
            
            // Only slerp the X and Z axes
            Vector3 startXZ = new Vector3(startPosition.x, 0f, startPosition.z);
            Vector3 targetXZ = new Vector3(targetPosition.x, 0f, targetPosition.z);
            Vector3 slerpedXZ = Vector3.Slerp(startXZ, targetXZ, interpolator);

            // Lerp the Y axis separately
            float lerpedY = Mathf.Lerp(startPosition.y, targetPosition.y, interpolator);

            // Combine the results (slerped XZ and lerped Y)
            transform.position = new Vector3(slerpedXZ.x, lerpedY, slerpedXZ.z);

            interpolator += Time.deltaTime * dynamicSpeed; // Increase the interpolator based on speed
            interpolator = Mathf.Clamp01(interpolator); // Clamp the interpolator to [0, 1] (to prevent overshooting)
            
            // transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation, 
            //     interpolator * Time.deltaTime
            // );    
        }
    }
}