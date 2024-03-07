using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GemaController : MonoBehaviour
{
   
    public KeyCode teclaGemaRosada = KeyCode.S;
    public KeyCode teclaGemaVerde = KeyCode.W;

    private bool gemaRosadaActivada = false;
    private bool gemaVerdeActivada = false;
    private Rigidbody2D rb;
    public Collider2D col;
    
    void Start()

    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(teclaGemaRosada))
        {
            if (gemaRosadaActivada)
            {
                rb.gravityScale = 1f;
                gemaRosadaActivada = false;
            }
        }

        if (Input.GetKeyDown(teclaGemaVerde))
        {
            if (gemaVerdeActivada)
            {
                //     // Cambiar la gravedad al valor correspondiente cuando la gema verde está activada
                rb.gravityScale = -1f;
                
                // Invoke("Active",0.8f);
                gemaVerdeActivada = false;
                
            }
        }
    }

    void ActivarGema(bool estado, Image iconoGema)
    {
        iconoGema.enabled = estado;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("GemaVerde"))
        {
            gemaVerdeActivada = true;
           
            
            
            Debug.Log("entro verde");
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("GemaRosada"))
        {
            gemaRosadaActivada = true;
            
            
            Debug.Log("entro rosa");
        }
        
        


    }
    // public void Active()
    // {
    //     col.enabled = true;
    // }

    // IEnumerator TimeRb()
    // {
    //     rb.gravityScale = -1f;
    //     yield return new WaitForFixedUpdate(2f);
    //     rb.gravityScale = -1f;
    // }


}