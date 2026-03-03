using TMPro;
using UnityEngine;

public class TextoPer7 : MonoBehaviour
{
    public GameObject caja;
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
        caja.gameObject.SetActive(false);
        info.gameObject.SetActive(false);

        Invoke("activarCaja", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            conta++;

            if (num < textos.Length)
            {
                text.text = textos[num++];
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
        text.text = textos[num];
        num++;
    }

    public void cambiarEscena()
    {
        Transicion trans = Object.FindAnyObjectByType<Transicion>();
        StartCoroutine(trans.SceneLoad(escena));
    }
}
