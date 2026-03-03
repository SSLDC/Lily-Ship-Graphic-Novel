using UnityEngine;

public class Bala : MonoBehaviour
{
    public Rigidbody bala;
    public GameObject[] disparador;
    private float contador;
    private float TiempoDisparo = 0.3f;
    public float daño = 1f;
    private float vel = 1000f;
    private ControlNave nave;
    private bool activo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        activo = true;
        nave = Object.FindAnyObjectByType<ControlNave>();
        disparador = GameObject.FindGameObjectsWithTag("Disparador"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (nave.vida>0)
        {

            if (activo && Input.GetKey(KeyCode.Q))
            {
                contador += Time.deltaTime;

                if (contador >= TiempoDisparo)
                {
                    Disparar();
                    contador = 0f;
                }
            }
            else contador = 0.3f;
        }
    }

    public void Disparar()
    {
        foreach (GameObject obj in disparador)
        {
            Rigidbody proyectil=Instantiate(bala, obj.transform.position, bala.transform.rotation);
            //proyectil.AddForce(obj.transform.right* vel);
        }
    }

    public float dañoBala()
    {
        return daño;
    }

    public void desac(bool stop)
    {
        activo = stop;
    }
}
