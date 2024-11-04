using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] GameObject bala;

    [SerializeField] Transform Pos;

    
    Vector3 iniPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iniPos = Pos.position + new Vector3(0,0,1);

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Instantiate(bala, iniPos, Quaternion.Euler(0, 0, 0));
        } 
    }
}
