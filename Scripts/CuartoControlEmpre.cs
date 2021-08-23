using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
//using System.IO.Ports;
using UnityEngine.UI;
using System.Linq;

public enum EstadoAscensor1E {LLamado, Stop, Movimiento, Planta, piso12,BajarB};
public enum EstadoAscensor2E {LLamado, Stop, Movimiento, Planta, piso0,SubirB};
public enum MoviAscensor1E {Subiendo, Bajando, Stop2};
public enum MoviAscensor2E {Subiendo, Bajando, Stop2};
public enum disponible1E {llego, noallegado,origen};
public enum disponible2E {llego, noallegado,origen};
public class CuartoControlEmpre : MonoBehaviour
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

    public EstadoAscensor1E Estado = EstadoAscensor1E.piso12;
    public EstadoAscensor2E Estado2 = EstadoAscensor2E.piso0;
    public MoviAscensor1E Movi = MoviAscensor1E.Bajando;
    public MoviAscensor2E Movi2 = MoviAscensor2E.Subiendo;
    public disponible1E llamada1 = disponible1E.origen;
    public disponible2E llamada2 = disponible2E.origen;
    public GameObject Ascen1;
    public GameObject Ascen2;
    int i=12;
    int j=1;
    public List<int> lista1piso = new List<int>();
    public List<int> lista2piso = new List<int>();
    

    // Start is called before the first frame update
    void OnEnable(){
        //serialPort.Open();  // se abre el puerto serial del dispositivo ESP8266 conectado al puerto COM 3
        //serialPort.ReadTimeout=100;
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
            if (llamada1 == disponible1E.llego){
                    lista1piso.RemoveAt(lista1piso.Count-1);
                   
            }
            if (llamada2 == disponible2E.llego){
                    lista2piso.RemoveAt(lista2piso.Count-1);
                    
            }
            if(lista1piso.Any()){
                Movi = MoviAscensor1E.Bajando;
            }else{
                Movi = MoviAscensor1E.Subiendo;
                Ascensor1=12;
                llamada1 = disponible1E.origen;
            }
            if(lista2piso.Any()){
                Movi2 = MoviAscensor2E.Subiendo;
            }else{
                Movi2 = MoviAscensor2E.Bajando;
                Ascensor2=0;
                llamada2 = disponible2E.origen;
            }
            
        
    }
   
    public void Solicitud_0 (){
        //solis += "1";
        if (Ascen2.transform.position.y!=0){
            piso_0 = true;
            Estado2 = EstadoAscensor2E.SubirB;
        }
        
    }
    public void Solicitud_1 (){
        //solis += "1";
        piso_1 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_2 (){
        //solis += ",2";
        piso_2 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_3 (){
        //solis += ",3";
        piso_3 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_4 (){
        //solis += ",4";
        piso_4 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_5 (){
        //solis += ",5";
        piso_5 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_6 (){
        //solis += ",6";
        piso_6 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_7 (){
        //solis += ",7";
        piso_7 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_8 (){
        //solis += ",8";
        piso_8 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_9 (){
        //solis += ",9";
        piso_9 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_10 (){
        //solis += ",10";
        piso_10 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_11 (){
        //solis += ",11";
        piso_11 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_12 (){
        //solis += ",12";
        piso_12 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_13 (){
        //solis += ",13";
        piso_13 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_14 (){
        //solis += ",14";
        piso_14 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_15 (){
        //solis += ",15";
        piso_15 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_16 (){
        //solis += ",16";
        piso_16 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_17 (){
        //solis += ",17";
        piso_17 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_18 (){
        //solis += ",18";
        piso_18 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_19 (){
        //solis += ",19";
        piso_19 = true;
        Estado2 = EstadoAscensor2E.SubirB;
    }
    public void Solicitud_20 (){
        //solis += ",20";
        piso_20 = true;
        Movi = MoviAscensor1E.Bajando;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_1B (){
        //solis += "1";
        piso_1 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_2B (){
        //solis += ",2";
        piso_2 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_3B (){
        //solis += ",3";
        piso_3 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_4B (){
        //solis += ",4";
        piso_4 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_5B (){
        //solis += ",5";
        piso_5 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_6B (){
        //solis += ",6";
        piso_6 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_7B (){
        //solis += ",7";
        piso_7 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_8B (){
        //solis += ",8";
        piso_8 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_9B (){
        //solis += ",9";
        piso_9 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_10B (){
        //solis += ",10";
        piso_10 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_11B (){
        //solis += ",11";
        piso_11 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_12B (){
        //solis += ",12";
        piso_12 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_13B (){
        //solis += ",13";
        piso_13 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_14B (){
        //solis += ",14";
        piso_14 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_15B (){
        //solis += ",15";
        piso_15 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_16B (){
        //solis += ",16";
        piso_16 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_17B (){
        //solis += ",17";
        piso_17 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_18B (){
        //solis += ",18";
        piso_18 = true;
        Estado = EstadoAscensor1E.BajarB;
    }
    public void Solicitud_19B (){
        //solis += ",19";
        piso_19 = true;
        Estado = EstadoAscensor1E.BajarB;
    }


}