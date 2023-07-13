using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrarPanel : MonoBehaviour
{
    public GameObject panel;
    public botones boton;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cerrar()
    {
        panel.SetActive(false);
        boton.puedePresionar = true;
    }
}
