using UnityEngine;

public class CortarTrozo : MonoBehaviour
{
    [Tooltip("Referencia al objeto que se va a cortar")]
    public GameObject pedazoTorta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cuchillo"))
        {
            //Instancia el trozo de torta al lado de la misma
            Instantiate(pedazoTorta, transform.position + new Vector3(0.5f, 0, 0), transform.rotation);

            //Instantiate(pedazoTorta, transform.position + new Vector3(0.05f, 0, 0), transform.rotation);

            //condicional para destrur la torta cuando le sacas 10 trozos?
            //Destroy(gameObject);
        }


    }
}
