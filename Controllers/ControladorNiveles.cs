using UnityEngine;
using UnityEngine.UI;

public class ControladorNiveles : MonoBehaviour
{
    private int num=0;
    private Button n1;
    private Button n2;
    private Button n3;
    public bool nivel3;
    private Button n4;
    private Image text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        n1=GameObject.Find("Nivel1").GetComponent<Button>();
        n2=GameObject.Find("Nivel2").GetComponent<Button> ();
        n3=GameObject.Find("Nivel3").GetComponent<Button>();
        n4=GameObject.Find("Salir").GetComponent <Button> ();
        n2.gameObject.SetActive (false);
        n3.gameObject.SetActive (false);
        n4.gameObject.SetActive (false);
        num = GenerarEnemigos.niveldesbloqueado;
        nivel3 = GenerarEnemigos.nivel3;
        text=GameObject.Find("MensajeNivel").GetComponent<Image> ();
        text.gameObject.SetActive (false);

        if (num >= 1) n2.gameObject.SetActive (true);
        if(n2.interactable==true && nivel3==true) n3.gameObject.SetActive (true);

        Invoke("Men", 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Men()
    {
        text.gameObject.SetActive(true);
        n4.gameObject.SetActive(true);
    }
    
}
