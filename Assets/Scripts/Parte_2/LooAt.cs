using UnityEngine;

public class LooAt : MonoBehaviour
{
    [SerializeField] Transform Nave;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Nave);
    }
}
