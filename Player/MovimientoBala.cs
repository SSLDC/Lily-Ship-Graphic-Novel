using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    private float vel=100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 1f);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * vel* Time.deltaTime);
    }
}
