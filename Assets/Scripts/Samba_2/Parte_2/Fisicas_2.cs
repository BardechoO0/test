using UnityEngine;

public class Fiasicas_2 : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    public float Speed;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float DesplZ = Input.GetAxis("Horizontal");

        rb.AddForce(Vector3.forward * DesplZ* Time.deltaTime * Speed);

        float DesplY = Input.GetAxis("Vertical");

       // rb.AddForce(Vector3.up * DesplY * Time.deltaTime * Speed);





    }
}
