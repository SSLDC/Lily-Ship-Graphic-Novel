using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Button[] botones;
    private Image text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GameObject.Find("Mensaje").GetComponent<Image>();
        text.gameObject.SetActive(false);

        foreach(Button b in botones)
        {
            b.gameObject.SetActive(false);
        }

        Invoke("activarMen", 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activarMen()
    {
        text.gameObject.SetActive(true);

        foreach (Button b in botones)
        {
            b.gameObject.SetActive(true);
        }
    }
}
