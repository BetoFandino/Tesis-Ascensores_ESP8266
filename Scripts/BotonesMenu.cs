using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void escenaResidencial(){
        SceneManager.LoadScene ("Residencial");
    }

    public void escenaEmpresarial(){
        SceneManager.LoadScene ("Empresarial");
    }
}
