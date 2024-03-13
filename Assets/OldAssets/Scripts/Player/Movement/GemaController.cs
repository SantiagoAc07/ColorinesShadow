using System.Collections;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class GemaController : MonoBehaviour
{
   
    public KeyCode teclaGemaRosada = KeyCode.S;
    public KeyCode teclaGemaVerde = KeyCode.W;

    private bool gemaRosadaActivada = false;
    private bool gemaVerdeActivada = false;
    private Rigidbody2D rb;
    public Light2D lightSprite;
    public Light2D lightTerrenoverde;
    public Light2D lightTerrenorosada;// Referencia a la luz del terreno
    public int puntos = 0;
    public PointsController controlarpoint;
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
                CambiarColor(Color.white);
                lightTerrenorosada.enabled = true;
                
                
                
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
                CambiarColor(Color.white);
                lightTerrenoverde.enabled = true;
                
                
                
            }
        }
    }
    
    void CambiarColor(Color color)
    {
        if (lightSprite != null)
        {
            lightSprite.color = color;
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
            CambiarColor(Color.green);
            lightTerrenoverde.enabled = false;
            puntos += 1;
            controlarpoint.UpdatePoints(puntos);

        }
        if (other.gameObject.layer == LayerMask.NameToLayer("GemaRosada"))
        {
            gemaRosadaActivada = true;
            CambiarColor(Color.magenta);
            lightTerrenorosada.enabled = false;
            puntos += 1;
            controlarpoint.UpdatePoints(puntos);
            
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