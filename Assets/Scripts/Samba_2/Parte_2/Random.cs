using UnityEngine;

public class Random : MonoBehaviour
{
    [Header("Intaciar")]

    [SerializeField] GameObject[] asset = new GameObject[2];

    [SerializeField] BoxCollider gameplayArea;

    [SerializeField] Transform Pos;

     Vector3 iniPos;

    void Start()
    {
        iniPos = transform.position + new Vector3(0,0,10);

        for (int i = 0; i < 9; i++)
        {
         
            int random = UnityEngine.Random.Range(0, asset.Length);

            print(random);

            /*if (random == 0)
            {
                Instantiate(asset[random], iniPos, Quaternion.Euler(0, 0, 0));
            }
            else if (random == 1) 
            {
                Instantiate(asset[random], iniPos + new Vector3(-10,0,0), Quaternion.Euler(0, 0, 0));
                
            }*/

            iniPos += new Vector3(0, 0, UnityEngine.Random.Range(5, 10));


            //La otra opcion

            Vector3 cambioPos = gameplayArea.bounds.size/2;

            Vector3 ramdomPos = new Vector3(
                UnityEngine.Random.Range(-cambioPos.x, cambioPos.x),
                UnityEngine.Random.Range(-cambioPos.y, cambioPos.y),
                UnityEngine.Random.Range(-cambioPos.z, cambioPos.z)
               );

            Instantiate(asset[random], ramdomPos +  gameplayArea.transform.position, Quaternion.identity);

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
