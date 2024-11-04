using System.Security.Cryptography;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public float speed_move;

    public float speed_rotar;
    void Start()
    {

    }

    public float posicionX;

    public float posicionZ;

    public Transform nave;




    // Update is called once per frame
    void Update()
    {
        transform.position = nave.transform.position - new Vector3(0,0,10);

        posicionX = transform.position.x;

        posicionZ = transform.position.z;


        float desplX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * desplX * Time.deltaTime * speed_move);

        float desplY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * desplY * Time.deltaTime * speed_move);

      

        if (posicionX <= -444)
        {
            transform.position = Vector3.zero;
        }


        if (posicionX > 550)
        {
            transform.position = Vector3.zero;
        }
        else
        {
            speed_move = 10;
        }



        if (posicionZ <= -344)
        {
            transform.position = Vector3.zero;
        }



        if (posicionZ > 651)
        {
            transform.position = Vector3.zero;
        }

    }
}
