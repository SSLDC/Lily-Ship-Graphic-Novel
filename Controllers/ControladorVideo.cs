using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ControladorVideo : MonoBehaviour
{
    public VideoPlayer player;
    public string escena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Transicion trans = Object.FindAnyObjectByType<Transicion>();
        StartCoroutine(trans.SceneLoad(escena));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
