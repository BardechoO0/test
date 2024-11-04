using UnityEngine;

public class Fiasicas : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    public float Speed;

    public float Speed_torque;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float DesplZ = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * DesplZ* Time.deltaTime * Speed);

        rb.AddForce( Vector3.up * Time.deltaTime * DesplZ * DesplZ * Speed, ForceMode.Acceleration);

     
        float TorqZ = Input.GetAxis("Horizontal");

        rb.AddTorque(Vector3.up * TorqZ * Time.deltaTime * Speed_torque);
        


    }
}
