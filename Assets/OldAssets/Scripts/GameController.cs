using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float distanciaRaycast;
    public LayerMask capaPared;
    public float segundosDeEspera;
    public bool puedeRecibirDano;

    public IntVariable vidas; // Inicia con 3 vidas
    public IntVariable score;
    
    private void Start()
    {
        puedeRecibirDano = true;
        vidas.SetValue(3);
    }

    private void Update()
    {
        // Create a vector of direction to the right in 2D space.
        Vector2 direccionDerecha = Vector2.right;

        
        // Perform a 2D Raycast from the current object's position.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direccionDerecha, distanciaRaycast, capaPared);

        // If there's a collision, execute the RestarVida() method.
        if (hit.collider != null && puedeRecibirDano)
        {
            StartCoroutine(RestarVida());
        }
    }

    IEnumerator RestarVida()
    {
        puedeRecibirDano = false;
        vidas.SetValue(vidas.Value - 1);
        yield return new WaitForSeconds(segundosDeEspera);
        puedeRecibirDano = true;
    }

    public void IncrementarPuntos(int cantidad)
    {
        score.SetValue(score.Value + cantidad);;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.right * distanciaRaycast);
    }
}
