using TMPro;
using UnityEditor.Rendering;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI myText;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Muerto")
        {
            Destroy(this.gameObject);

            myText.text = "Has mueto";
        }
    }
    void Update()
    {
        
    }
}
