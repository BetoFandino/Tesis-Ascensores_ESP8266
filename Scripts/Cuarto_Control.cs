using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
//using System.IO.Ports;
using UnityEngine.UI;
using System.Linq;


public enum EstadoAscensor1 {LLamado, Stop, Movimiento, Planta, piso12};
public enum EstadoAscensor2 {LLamado, Stop, Movimiento, Planta, piso0};
public enum MoviAscensor1 {Subiendo, Bajando, Stop2};
public enum MoviAscensor2 {Subiendo, Bajando, Stop2};
public enum disponible1 {llego, noallegado,origen};
public enum disponible2 {llego, noallegado,origen};

public class Cuarto_Control : MonoBehaviour
{
    //public SerialPort serialPort=new SerialPort("COM3",115200);
    public wrmhl device = new wrmhl();
    string Ascen;

    public int Ascensor1;
    public int Ascensor2;

    
    public bool piso_0 = false;
    public bool piso_1 = false;
    public bool piso_2 = false;
    public bool piso_3 = false;
    public bool piso_4 = false;
    public bool piso_5 = false;
    public bool piso_6 = false;
    public bool piso_7 = false;
    public bool piso_8 = false;
    public bool piso_9 = false;
    public bool piso_10 = false;
    public bool piso_11 = false;
    public bool piso_12 = false;
    public bool piso_13 = false;
    public bool piso_14 = false;
    public bool piso_15 = false;
    public bool piso_16 = false;
    public bool piso_17 = false;
    public bool piso_18 = false;
    public bool piso_19 = false;
    public bool piso_20 = false;

    public EstadoAscensor1 Estado = EstadoAscensor1.piso12;
    public EstadoAscensor2 Estado2 = EstadoAscensor2.piso0;
    public MoviAscensor1 Movi = MoviAscensor1.Bajando;
    public MoviAscensor2 Movi2 = MoviAscensor2.Subiendo;
    public disponible1 llamada1 = disponible1.origen;
    public disponible2 llamada2 = disponible2.origen;
    public GameObject Ascen1;
    public GameObject Ascen2;
    int i=12;
    int j=1;
    public List<int> lista1piso = new List<int>();
    public List<int> lista2piso = new List<int>();
    

    // Start is called before the first frame update
    void OnEnable(){
    // se abre el puerto serial del dispositivo ESP8266 conectado al puerto COM 3
        
        device.set("COM3",115200,10000,1);
        device.connect();
    }
    void OnDisable(){
        //serialPort.Close();
        device.close();
    }
    void Start()
    {

        
    }
    // Update is called once per frame
    void Update()
    {
         
        ///////////////////////////////////////
        print(device.readQueue());
        string[] piso1 = device.readQueue().Split(',');
                
              // Decodificación y envio de ordenes a las cabinas 1 y 2  
            Ascen = piso1[1];
                
            if (Ascen == "A1"){
                    lista1piso.Add(int.Parse(piso1[0]));
                    
                    if(lista1piso.Last()==i){
                        lista1piso.RemoveAt(lista1piso.Count-1);
                    }
                    i=lista1piso.Last();
                    lista1piso.Sort();
                    Ascensor1=lista1piso.Last();
                    
                         
            }
            if (Ascen== "A2"){ 
                
                    lista2piso.Add(int.Parse(piso1[0]));
                    if(lista2piso.Last()==j){
                        lista2piso.RemoveAt(lista2piso.Count-1);
                    }
                    j=lista2piso.Last();
                    lista2piso.Reverse();
                    Ascensor2=lista2piso.Last();
                    

                
            }
            if (llamada1 == disponible1.llego){
                    lista1piso.RemoveAt(lista1piso.Count-1);
                   
            }
            if (llamada2 == disponible2.llego){
                    lista2piso.RemoveAt(lista2piso.Count-1);
                    
            }
            if(lista1piso.Any()){
                Movi = MoviAscensor1.Bajando;
            }else{
                Movi = MoviAscensor1.Subiendo;
                Ascensor1=12;
                llamada1 = disponible1.origen;
            }
            if(lista2piso.Any()){
                Movi2 = MoviAscensor2.Subiendo;
            }else{
                Movi2 = MoviAscensor2.Bajando;
                Ascensor2=0;
                llamada2 = disponible2.origen;
            }
            
        
    }
   
    public void Solicitud_0 (){
        //solis += "1";
        if (Ascen2.transform.position.y!=0){
            piso_0 = true;
            Estado = EstadoAscensor1.LLamado;
        }
        
    }
    public void Solicitud_1 (){
        //solis += "1";
        piso_1 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_2 (){
        //solis += ",2";
        piso_2 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_3 (){
        //solis += ",3";
        piso_3 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_4 (){
        //solis += ",4";
        piso_4 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_5 (){
        //solis += ",5";
        piso_5 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_6 (){
        //solis += ",6";
        piso_6 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_7 (){
        //solis += ",7";
        piso_7 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_8 (){
        //solis += ",8";
        piso_8 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_9 (){
        //solis += ",9";
        piso_9 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_10 (){
        //solis += ",10";
        piso_10 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_11 (){
        //solis += ",11";
        piso_11 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_12 (){
        //solis += ",12";
        piso_12 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_13 (){
        //solis += ",13";
        piso_13 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_14 (){
        //solis += ",14";
        piso_14 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_15 (){
        //solis += ",15";
        piso_15 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_16 (){
        //solis += ",16";
        piso_16 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_17 (){
        //solis += ",17";
        piso_17 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_18 (){
        //solis += ",18";
        piso_18 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_19 (){
        //solis += ",19";
        piso_19 = true;
        Estado = EstadoAscensor1.LLamado;
    }
    public void Solicitud_20 (){
        //solis += ",20";
        piso_20 = true;
        Movi = MoviAscensor1.Bajando;
        Estado = EstadoAscensor1.LLamado;
    }
    


}
