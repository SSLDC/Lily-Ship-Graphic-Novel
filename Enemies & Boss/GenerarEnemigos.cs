using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
using TMPro;
using UnityEngine.SceneManagement;

public class GenerarEnemigos : MonoBehaviour
{
    public bool Ganador;
    public static int niveldesbloqueado=0;
    public GameObject[] enemigo;

    private float LimitX;
    private float LimitY;
    private float posZ=80f;

    private int contador;
    private Image imagen;
    private Transform escala;
    private GameObject lienzo;
    public Button[] botones;
    public Sprite[] imagenes;

    
    private GameObject textIma;
    private GameObject Panel;
    private TextMeshProUGUI textPuntos;
    private GameObject win;
    private Button TiempoGa;
    private Button TiempoLo;
    private TextMeshProUGUI fondoWL;


    private Bala bala;

    private ControlNave nave;

    private bool pausa;
    public static bool nivel3=false;
    private float crono;
    private float tiempoEspera = 0.17f;
    private string nombreEscena;

    private bool terminado;
    public int puntosGana;

    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pausa = true;
        lienzo = GameObject.Find("Lienzo");
        animator=lienzo.GetComponent<Animator>();
        nave =Object.FindAnyObjectByType<ControlNave>();
        LimitX = nave.limitX;
        LimitY = nave.limitY;
        imagen=GameObject.Find("cambiaImagen").GetComponent<Image>();
        escala = imagen.GetComponent<Transform>();
        imagen.type = Image.Type.Simple;
        imagen.sprite = imagenes[0];
        Time.timeScale = 1;
        bala=Object.FindAnyObjectByType<Bala>();
        textIma = GameObject.Find("FondoPausa");
        textIma.gameObject.SetActive(false);
        Panel = GameObject.Find("PausaPanel");
        Panel.SetActive(false);

        textPuntos= GameObject.Find("Puntos").GetComponent<TextMeshProUGUI>();
        textPuntos.text = "Puntos: 0";

        win = GameObject.Find("PanelWin");
        win.gameObject.SetActive(false);

        fondoWL=win.GetComponentInChildren<TextMeshProUGUI>();
        TiempoGa = GameObject.Find("Terminado").GetComponent<Button>();
        TiempoLo = GameObject.Find("TerminadoLose").GetComponent<Button>();
        TiempoGa.gameObject.SetActive(false);
        TiempoLo.gameObject.SetActive(false);
        terminado = false;
        nombreEscena = SceneManager.GetActiveScene().name;

        InvokeRepeating("Spawner", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

       /* if (Ganador)
        {

           
        }*/
        
        if(nave.vida<=0){
            Invoke("Panelwl", 0.30f);
        }

        if(Ganador || nave.vida <= 0) terminado = true;

        if (!terminado)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pausarJue(pausa);
            }
        }

    }

    public void Spawner()
    {
        int num=Random.Range(0, enemigo.Length);
        float x=Random.Range(-LimitX, LimitX);
        float y=Random.Range(-LimitY, LimitY);

        Instantiate(enemigo[num], new Vector3(x, y, posZ), Quaternion.identity);
    }

    public void EnemigosDestruidos(int cont)
    {
        contador += cont;
        textPuntos.text = "Puntos: " + contador;

        if (contador >= puntosGana)
        {
            Ganador = true;
            GanarJuego();
        }
    }


    void GanarJuego()
    {
        CancelInvoke("Spawner");
        bala.desac(false);
        nave.vida = nave.getVidaMax();
        nave.setControl();
        Invoke("Panelwl", 0.30f);
        if (nombreEscena.Equals("Nivel1"))
        {
            niveldesbloqueado=1;
        }
        if (nombreEscena.Equals("Nivel2"))
        {
            niveldesbloqueado = 2;
            nivel3 = true;
        }
    }

    public void cambiarCara(float vida, float vidaMax)
    {
        float vidaI = vida / vidaMax * 100;

            if (vidaI <= 0)
            {
                escala.localScale = new Vector3(1.4f, 1.3f, 1);
                imagen.rectTransform.anchoredPosition = new Vector3(-298, -17, 0);
                imagen.sprite = imagenes[2];
                CancelInvoke("Spawner");
             }
            else if (vidaI <= 60)
            {
                escala.localScale=new Vector3(1.4f, 1.3f, 1);
                imagen.rectTransform.anchoredPosition = new Vector3(-294, -39, 0);
                imagen.sprite = imagenes[1];
                StartCoroutine(cambiaExD());
            }
            else
            {
                StartCoroutine(cambiaEx());
            }
    
    }

    public IEnumerator cambiaEx()
    {

        escala.localScale = new Vector3(1.3f, 1.3f, 1);
        imagen.rectTransform.anchoredPosition = new Vector3(-251, -19, 0);
        imagen.sprite = imagenes[3];
        imagen.color = new Color(128f / 255f, 16f / 255f, 16f / 255f);

        yield return new WaitForSeconds(1f);

        escala.localScale = new Vector3(1f, 1f, 1);
        imagen.rectTransform.anchoredPosition = new Vector3(-294, -31, 0);
        imagen.sprite = imagenes[0];
        imagen.color = new Color(200f / 255f, 199f / 255f, 199f / 255f);
    }

    public IEnumerator cambiaExD()
    {
        escala.localScale = new Vector3(1.3f, 1.3f, 1);
        imagen.rectTransform.anchoredPosition = new Vector3(-251, -19, 0);
        imagen.sprite = imagenes[3];
        imagen.color = new Color(128f / 255f, 16f / 255f, 16f / 255f);

        yield return new WaitForSeconds(1f);

        escala.localScale = new Vector3(1.4f, 1.3f, 1);
        imagen.rectTransform.anchoredPosition = new Vector3(-294, -39, 0);
        imagen.sprite = imagenes[1];
        imagen.color = new Color(200f / 255f, 199f / 255f, 199f / 255f);
    }

    public void pausar(bool stop)
    {
        foreach (Button b in botones)
        {
            b.gameObject.SetActive(stop);
        }
    }

    public IEnumerator pausaAni()
    {
        animator.SetBool("pause", true);

        yield return new WaitForSeconds(0.18f);

        Time.timeScale = 0;
        textIma.gameObject.SetActive(true);
        Panel.SetActive(true);
        pausar(true);
    }

    public void pausarJue(bool pausa)
    {
        crono += Time.deltaTime;

        if (crono >= tiempoEspera)
        {
            if (pausa)
            {
                this.pausa = false;
                bala.desac(false);
                StartCoroutine(pausaAni());
                crono = 0f;
            }
            else
            {
                pausar(false);
                this.pausa = true;
                bala.desac(true);
                textIma.gameObject.SetActive(false);
                Panel.SetActive(false);
                animator.SetBool("pause", false);
                Time.timeScale = 1;
            }
        }
        else
        {
            crono = 0.17f;
        }
    }

    public void Panelwl()
    {
        win.gameObject.SetActive(true);
        if (Ganador)
        {
            fondoWL.text = "Ganaste";
            TiempoGa.gameObject.SetActive(true);
        }
        else
        {
            fondoWL.text = "Perdiste";
            TiempoLo.gameObject.SetActive(true);
        }
        
    }

}
