using UnityEngine;

public class Bala_2 : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    public float Speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Muerto")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
    void Update()
    {
        //rb.AddForce (Vector3.forward *Time.deltaTime * Speed, ForceMode.Acceleration);

        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }
}
