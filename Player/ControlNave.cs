using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ControlNave : MonoBehaviour
{
    public float posZ;
    private float horz;
    private float vert;
    public float limitX = 10;
    public float limitY = 7;
    private float maxRot = 35;
    public float vida = 30f;
    private float vidaMax;
    public GameObject explosion;
    private Image barra;
    private bool activo = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaMax = vida;
        barra=GameObject.Find("barraVital").GetComponent<Image>();
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = new Vector3(0, 16, 70);
        Camera.main.transform.localEulerAngles=new Vector3(0, 180, 0);
        Camera.main.transform.LookAt(transform);

        posZ =transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (activo) Movimiento();
    }

    public void Movimiento()
    {
                
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        transform.position=new Vector3(horz*limitX, vert*limitY, posZ);
     
        transform.eulerAngles=new Vector3(0, 180, horz*maxRot);
       
    }

    public void RestarVida(float daño)
    {
        GenerarEnemigos expre=Object.FindAnyObjectByType<GenerarEnemigos>();

            vida -= daño;
            expre.cambiarCara(vida, vidaMax);
            barra.fillAmount = vida/vidaMax;


        MeshRenderer[] meshRenderers = gameObject.GetComponentsInChildren<MeshRenderer>();
        ParticleSystem[] particleSystems = gameObject.GetComponentsInChildren<ParticleSystem>();
        GameObject[] disparadores = GameObject.FindGameObjectsWithTag("Disparador");


        if (vida <= 0)
        {
            activo = false;
            horz = 0f;
            vert = 0f;


            foreach (MeshRenderer mesh in meshRenderers)
            {
                mesh.enabled = false;
            }

            foreach (ParticleSystem particle in particleSystems)
            {
                particle.Stop();
            }

            foreach (GameObject dis in disparadores)
            {
                dis.SetActive(false);
            }
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        }
        /*
        if (vida <= 0)
        {
            vida = 0;
            Debug.Log("Instancia entra");
            Instantiate(explosion, new Vector3(0, 0, 0), Quaternion.identity);
        }
        */

    }

    public float getVidaMax()
    {
        return vidaMax;
    }

    public void setControl()
    {
        activo = false;
        horz = 0f;
        vert = 0f;
    }
}
