using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
   public Vector3 posicion;

    public Vector3 Rotar;

    public Transform initpos;

    [SerializeField] Transform objetio;

    float Gravedad = 1;
   

    public float speed;

    public float speed2;

    [SerializeField] GameObject Nave;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        initpos.position = posicion;

        posicion = posicion + Vector3.forward*Time.deltaTime*speed;

        //transform.Translate(Vector3.forward*Time.deltaTime*speed);

        transform.Rotate(Rotar*Time.deltaTime*speed2);

        transform.LookAt(objetio.transform.position);
 

       transform.Translate(Vector3.down*Gravedad*Time.deltaTime);

        if (transform.position.y < -1)
        {
            Gravedad = 0;


        }
        else
        {
            Gravedad = 1;

        }

        



       // transform.Rotate(Vector3.up * Time.deltaTime * speed2);




    }
}
