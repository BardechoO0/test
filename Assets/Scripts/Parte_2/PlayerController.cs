using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed_move;

    public float speed_rotar;



    Vector3 lastframePos;

    Vector3 currentframePos;

    Quaternion lastframeRot;


    void Start()
    {
        lastframePos = currentframePos;
    }

    public float posicionX;

    public float posicionZ;



  

    
    // Update is called once per frame
    void Update()
    {
      

        posicionX = transform.position.x;

        posicionZ = transform.position.z;


        float desplX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * desplX * Time.deltaTime * speed_move);

        float desplY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up*desplY * Time.deltaTime * speed_move);

        if (Input.GetKey(KeyCode.Q))
        {

            transform.Rotate(Vector3.down *Time.deltaTime*speed_move);

        }

        if (Input.GetKey(KeyCode.E) )
        {

            transform.Rotate(Vector3.up * Time.deltaTime * speed_move);

        }

        if(posicionX <= -444)
        {
            transform.position = Vector3.zero;
        }
       

        if (posicionX > 550)
        {
            transform.position = Vector3.zero;
        }
       



        if (posicionZ <= -344)
        {
            transform.position = Vector3.zero;
        }
       
        

        if (posicionZ > 651)
        {
            transform.position = Vector3.zero;
        }
      



        currentframePos = transform.position;   

        Quaternion rotation = Quaternion.LookRotation(currentframePos-lastframePos);

        lastframePos = currentframePos;

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0.1f);



    }
}
