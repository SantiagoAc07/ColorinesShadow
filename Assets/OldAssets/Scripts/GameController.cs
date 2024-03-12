using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float distanciaRaycast;
    public LayerMask capaPared;
    public LifeController LifeController;
    public float segundosDeEspera;
    public IntVariable puntos;
    public IntVariable vidas; // Inicia con 3 vidas
    public bool puedeRecibirDano;

    private void Start()
    {
        puedeRecibirDano = true;
        LifeController.Subscribe();
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
        Debug.Log(vidas.Value);
        yield return new WaitForSeconds(segundosDeEspera);
        puedeRecibirDano = true;
    }

    public void IncrementarPuntos(int cantidad)
    {
        puntos.SetValue(puntos.Value + cantidad);;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, Vector2.right * distanciaRaycast);
    }
}
