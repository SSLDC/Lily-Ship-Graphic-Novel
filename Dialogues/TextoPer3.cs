using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextoPer3 : MonoBehaviour
{
    public GameObject caja;
    public Image imagen;
    public Sprite[] imagenes;
    public string[] textos;
    private TextMeshProUGUI text;
    private TextMeshProUGUI info;
    private int num = 0;
    public string escena;
    private int conta = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GameObject.Find("Texto").GetComponent<TextMeshProUGUI>();
        info = GameObject.Find("Informacion").GetComponent<TextMeshProUGUI>();
        imagen.sprite = imagenes[0];
        caja.gameObject.SetActive(false);
        info.gameObject.SetActive(false);

        Invoke("activarCaja", 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            conta++;

            if (num == 1 || num==2) imagen.sprite = imagenes[0];
            else if(num==3)imagen.sprite = imagenes[1];

            if (num < textos.Length)
            {
                text.text = textos[num++];
                if (num == textos.Length) imagen.sprite = imagenes[0];
            }

            if (conta > textos.Length)
            {
                cambiarEscena();
            }
        }

    }
    public void activarCaja()
    {
        caja.gameObject.SetActive(true);
        info.gameObject.SetActive(true);
        imagen.sprite = imagenes[1];
        text.text = textos[num];
        num++;
    }

    public void cambiarEscena()
    {
        Transicion trans = Object.FindAnyObjectByType<Transicion>();
        StartCoroutine(trans.SceneLoad(escena));
    }
}
