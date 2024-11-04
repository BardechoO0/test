using UnityEngine;

public class Mover_enemigos : MonoBehaviour
{
    private Vector3 IniPos;

    private Vector3 IniPost2;

    public float Speed;

    int n = 1;


    void Start()
    {
        IniPost2 = transform.position;
    }

   
    void Update()
    {
        IniPos = transform.position;


        transform.Translate(Time.deltaTime * Vector3.forward * Speed * n);

        if ( IniPost2.z  >= transform.position.z  )
        {

            n = 1;
            

        } else if(IniPost2.z + 10 <= transform.position.z )
        {


            n = -1;
            

        }
        

    }
}
