using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class MovimientoEnemigo : MonoBehaviour
{
    public float vel;
    public Material[] material;
    public float vida;
    private Light pointl;
    private Color normalCo=new Color(1f, 0.537f, 0.259f, 1f);
    private Color ataqueco=Color.white;
    public float dañoEne;
    public GameObject explosion;
    public int puntos; 
    private GenerarEnemigos ene;
    private bool destruido = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

      ene = Object.FindAnyObjectByType<GenerarEnemigos>();
      pointl = gameObject.GetComponentInChildren<Light>();
      pointl.color = normalCo;

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        transform.Translate(Vector3.back * vel * Time.deltaTime);

        if(gameObject.transform.position.z<=-11) Destroy(gameObject);
        
    }

    public void OnTriggerEnter(Collider other)
    {
        ControlNave nave = Object.FindAnyObjectByType<ControlNave>();
        Bala bala=Object.FindAnyObjectByType<Bala>();

        if (other.gameObject.CompareTag("Bala"))
        {
            this.vida -= bala.dañoBala();
            Destroy(other.gameObject);

            StartCoroutine(cambiaColor());

            if (vida < 0 && destruido==false)
            {
                destruido=true;
                Destroy(gameObject);
                ene.EnemigosDestruidos(this.puntos);
                GameObject instanciaExplosion = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
                Destroy(instanciaExplosion, 5f);
            }
        }

        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            GameObject instanciaExplosion = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(instanciaExplosion, 5f);
            nave.RestarVida(dañoEne);

        }
    }


    public IEnumerator cambiaColor()
    {
       
       pointl.color = ataqueco;

       yield return new WaitForSeconds(0.1f);

       pointl.color = normalCo;
    }
}
