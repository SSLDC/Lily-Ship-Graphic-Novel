using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMusica : MonoBehaviour
{
    private static ControladorMusica instancia;

    // AudioSource para reproducir la música
    private AudioSource audioSource;

    // Escenas donde la música debe reproducirse
    public string[] escenasConMusica;

    void Awake()
    {
        // Asegurar que solo haya una instancia
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instancia != this)
        {
            Destroy(gameObject); // Destruir duplicados
            return;
        }

        // Obtener el AudioSource del objeto
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // Suscribirse al evento de carga de escenas
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Verificar si la música debe reproducirse en la escena actual
        bool reproducirMusica = false;
        foreach (string escena in escenasConMusica)
        {
            if (scene.name == escena)
            {
                reproducirMusica = true;
                break;
            }
        }

        // Pausar o reproducir la música según la escena
        if (reproducirMusica)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Stop(); // Detiene el audio completamente y resetea el tiempo
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause(); // Pausa la música si está sonando
            }
        }
    }

    void OnDestroy()
    {
        // Desuscribirse del evento para evitar errores
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
