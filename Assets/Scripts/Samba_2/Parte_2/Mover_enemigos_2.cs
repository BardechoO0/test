using UnityEngine;

public class Mover_enemigos_2 : MonoBehaviour
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


        transform.Translate(Time.deltaTime * Vector3.right * Speed * n);

        if ( IniPost2.x  >= transform.position.x  )
        {

            n = 1;
            

        } else if(IniPost2.x + 20 <= transform.position.x )
        {


            n = -1;
            

        }
        

    }
}
