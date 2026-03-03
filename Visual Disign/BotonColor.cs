using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonColor : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler, IPointerDownHandler
{
    private TextMeshProUGUI text;
    public string escena;
    private string nom;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text=GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = Color.white;
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (text.text=="Reanudar") { 
            GenerarEnemigos pausa=Object.FindAnyObjectByType<GenerarEnemigos>();
            pausa.pausarJue(false);
        }
        if (text.text == "Cerrar")
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
        else {
            Transicion trans = Object.FindAnyObjectByType<Transicion>();
            text.color = Color.white;
            StartCoroutine(trans.SceneLoad(escena));
        }
    
    }

    // Se llama cuando el cursor sale del botón
    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = Color.black;
    }

    // Se llama cuando se presiona el botón
    public void OnPointerDown(PointerEventData eventData)
    {
        text.color = Color.white;
    }
    
}
