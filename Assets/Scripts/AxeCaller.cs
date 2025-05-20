using UnityEngine;

public class AxeCaller : MonoBehaviour
{
    public float interpolator = 0f;
    private bool comeBack = false;
    private Vector3 startPosition;
    public Vector3 targetPosition; // Hand of Kratos
    public float speed = 1f;
    [SerializeField] private Transform kratosHand;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            comeBack = true;
            startPosition = transform.position;
        }
        
        targetPosition = kratosHand.position;

        if (comeBack)
        {
            transform.position = Vector3.Slerp(startPosition, targetPosition, interpolator);
            interpolator += Time.deltaTime * speed; 
            interpolator = Mathf.Clamp01(interpolator);
            
            // transform.rotation = Quaternion.Slerp(transform.rotation, transform.rotation, 
            //     interpolator * Time.deltaTime
            // );    
        }
        
    }
}
