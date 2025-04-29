using UnityEngine;

public class AxeThrower : MonoBehaviour
{
    [SerializeField] private GameObject axeParent;
    [SerializeField] private GameObject axe;
    [SerializeField] private Rigidbody axeRigidbody;
    [SerializeField] private float forwardMultiplier = 20f;
    [SerializeField] private float torqueMultiplier = 15f;
    [SerializeField] private GameObject playerHand;

    private void Start()
    {
        Debug.Log(axeRigidbody.maxAngularVelocity); 
        // For some reason (?), Unity decided to change the maxAngularVelocity to 50 on Unity 6. It is 7 on Unity 2022. 
        // Find out thanks to https://discussions.unity.com/t/using-addtorque-and-torque-isnt-increasing-over-time/655147.
        axeRigidbody.maxAngularVelocity = 50f;
    }
    
    public void ThrowAxe()
    {
        axeParent.transform.parent = null;
        axeRigidbody.isKinematic = false;
        axeRigidbody.AddForce(axeParent.transform.forward * forwardMultiplier, ForceMode.Impulse);
        //axeRigidbody.AddForce(playerHand.transform.forward * forwardMultiplier, ForceMode.Impulse);
        axeRigidbody.AddTorque(axe.transform.forward * -torqueMultiplier, ForceMode.Impulse);
    }

}
