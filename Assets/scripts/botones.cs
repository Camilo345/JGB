using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class botones : MonoBehaviour
{
    public Camera cam;
    public GameObject OBJvideo;
    public bool puedePresionar=true;

    private Vector3 PosMouse;
    private Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        OBJvideo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && puedePresionar)
        {
            lanzarRay();
        }
    }

    void lanzarRay()
    {
        PosMouse = Input.mousePosition;
        PosMouse = cam.ScreenToWorldPoint(PosMouse);
        RaycastHit hit;
        Physics.Raycast(PosMouse, Vector3.down, out hit, 10);

        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction, out hit))
        {
            if (hit.collider.gameObject.CompareTag("btinfo"))
            {
                video();
            }
            if (hit.collider.gameObject.CompareTag("btaprende"))
            {
                web();
            }
            if (hit.collider.gameObject.CompareTag("btpreguntas"))
            {
                preguntas();
            }
            if (hit.collider.gameObject.CompareTag("btregalo"))
            {
                regalo();
            }

        }
    }

    void video()
    {
        OBJvideo.SetActive(true);
    }

    void web()
    {

        Application.OpenURL("https://www.jgb.com.co/");
    }

    void preguntas()
    {
        SceneManager.LoadScene(1);
    }

    void regalo()
    {
        Application.OpenURL("https://jgbar-a7ce0.web.app");
    }
}
