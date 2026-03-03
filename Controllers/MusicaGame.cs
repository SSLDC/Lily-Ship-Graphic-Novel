using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaGame : MonoBehaviour
{

    private static MusicaGame instancia;

    // Escenas donde el objeto debe existir
    public string[] escenasPersistentes;

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
        }
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // Suscribirse al evento de carga de escenas
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Verificar si la escena actual está en la lista de escenas persistentes
        bool debeExistir = false;
        foreach (string escena in escenasPersistentes)
        {
            if (scene.name == escena)
            {
                debeExistir = true;
                break;
            }
        }

        // Si la escena actual no está en la lista, destruir el objeto
        if (!debeExistir)
        {
            Destroy(gameObject);
        }
        else
        {
            // Si debe existir pero fue destruido, recrearlo
            if (instancia == null)
            {
                instancia = this;
                DontDestroyOnLoad(gameObject);
            }
        }
    }

    void OnDestroy()
    {
        // Desuscribirse del evento para evitar errores
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
