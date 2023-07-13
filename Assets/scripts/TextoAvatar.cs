using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextoAvatar : MonoBehaviour
{
    public TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarTexto(string mensaje)
    {
      texto.text = mensaje;
    }

 
}
