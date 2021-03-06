using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.IO.Ports;
using UnityEngine.UI;


public class Movimiento_Ascensor : MonoBehaviour
    
{
    //public SerialPort serialPort=new SerialPort("COM3",115200);
    
    public int PisoActual=0;
    //public int PisoSiguiente=0;
    public Cuarto_Control PisoSiguiente;
    public Cuarto_Control piso_0;
    public Cuarto_Control piso_1;
    public Cuarto_Control piso_2;
    public Cuarto_Control piso_3;
    public Cuarto_Control piso_4;
    public Cuarto_Control piso_5;
    public Cuarto_Control piso_6;
    public Cuarto_Control piso_7;
    public Cuarto_Control piso_8;
    public Cuarto_Control piso_9;
    public Cuarto_Control piso_10;
    public Cuarto_Control piso_11;
    public Cuarto_Control piso_12;
    public Cuarto_Control piso_13;
    public Cuarto_Control piso_14;
    public Cuarto_Control piso_15;
    public Cuarto_Control piso_16;
    public Cuarto_Control piso_17;
    public Cuarto_Control piso_18;
    public Cuarto_Control piso_19;
    public Cuarto_Control piso_20;

   

    public Text numPiso;

    public GameObject cuarto;
    public GameObject Ascen2;

    public int pisnum=0;

    
    // Start is called before the first frame update
    void Start()
    {
        PisoSiguiente = FindObjectOfType<Cuarto_Control>(); // se lee el valor del piso solicitado que llego del script de cuarto de control
        piso_0 = FindObjectOfType<Cuarto_Control>();
        piso_1 = FindObjectOfType<Cuarto_Control>();
        piso_2 = FindObjectOfType<Cuarto_Control>();
        piso_3 = FindObjectOfType<Cuarto_Control>();
        piso_4 = FindObjectOfType<Cuarto_Control>();
        piso_5 = FindObjectOfType<Cuarto_Control>();
        piso_6 = FindObjectOfType<Cuarto_Control>();
        piso_7 = FindObjectOfType<Cuarto_Control>();
        piso_8 = FindObjectOfType<Cuarto_Control>();
        piso_9 = FindObjectOfType<Cuarto_Control>();
        piso_10 = FindObjectOfType<Cuarto_Control>();
        piso_11 = FindObjectOfType<Cuarto_Control>();
        piso_12 = FindObjectOfType<Cuarto_Control>();
        piso_13 = FindObjectOfType<Cuarto_Control>();
        piso_14 = FindObjectOfType<Cuarto_Control>();
        piso_15 = FindObjectOfType<Cuarto_Control>();
        piso_16 = FindObjectOfType<Cuarto_Control>();
        piso_17 = FindObjectOfType<Cuarto_Control>();
        piso_18 = FindObjectOfType<Cuarto_Control>();
        piso_19 = FindObjectOfType<Cuarto_Control>();
        piso_20 = FindObjectOfType<Cuarto_Control>();


    }

    // Update is called once per frame
    void Update()
    {
        numPiso.text = "Piso ascensor 1: " + PisoActual.ToString();
        pisnum = PisoSiguiente.Ascensor1;
        if (PisoSiguiente.Ascensor2==0){
            if((cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_0.piso_0 == true) && Ascen2.transform.position.y!=0){
            pisnum = 0;
            } 
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_1.piso_1 == true){
                pisnum = 1;
            } 
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_2.piso_2 == true){
                pisnum = 2;
            } 
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_3.piso_3 == true){
                pisnum = 3;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_4.piso_4 == true){
                pisnum = 4;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_5.piso_5 == true){
                pisnum = 5;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_6.piso_6 == true){
                pisnum = 6;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_7.piso_7 == true){
                pisnum = 7;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_8.piso_8 == true){
                pisnum = 8;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_9.piso_9 == true){
                pisnum = 9;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_10.piso_10 == true){
                pisnum = 10;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_11.piso_11 == true){
                pisnum = 11;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_12.piso_12 == true){
                pisnum = 12;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_13.piso_13 == true){
                pisnum = 13;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_14.piso_14 == true){
                pisnum = 14;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_15.piso_15 == true){
                pisnum = 15;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_16.piso_16 == true){
                pisnum = 16;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_17.piso_17 == true){
                pisnum = 17;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_18.piso_18 == true){
                pisnum = 18;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_19.piso_19 == true){
                pisnum = 19;
            }  
            if(cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando && piso_20.piso_20 == true){
                pisnum = 20;
            }   
        }
        
        
        if (pisnum>PisoActual && cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Subiendo){ //para subir el ascensor
            //Debug.Log("Subiendo");
            PisoActual++;
            transform.position = new Vector3(transform.position.x,PisoActual/2,transform.position.z);
            Thread.Sleep(500);
            cuarto.GetComponent<Cuarto_Control>().llamada1=disponible1.noallegado;                        
        }

        if (pisnum<PisoActual && cuarto.GetComponent<Cuarto_Control>().Movi == MoviAscensor1.Bajando ){    // para bajar el ascensor  
            //Debug.Log("Bajando");
            PisoActual--; 
            transform.position = new Vector3(transform.position.x,PisoActual/2,transform.position.z);
            Thread.Sleep(500);
            cuarto.GetComponent<Cuarto_Control>().llamada1=disponible1.noallegado;                                       
        }
        if (PisoActual == pisnum){
            if(cuarto.GetComponent<Cuarto_Control>().llamada1!=disponible1.origen){
                cuarto.GetComponent<Cuarto_Control>().llamada1=disponible1.llego;
            }
            
            //Debug.Log("Llegaste a tu destino");
           /* if (pisnum==20){
                Thread.Sleep(2000);
                cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Bajando;
                piso_20.piso_20 = false;
                
            }
            if (pisnum==19){
                Thread.Sleep(2000);
                piso_19.piso_19 = false;
                if (PisoSiguiente.Ascensor1==19){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==18){
                Thread.Sleep(2000);
                piso_18.piso_18 = false;
                if (PisoSiguiente.Ascensor1==18){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==17){
                Thread.Sleep(2000);
                piso_17.piso_17 = false;
                if (PisoSiguiente.Ascensor1==17){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==16){
                Thread.Sleep(2000);
                piso_16.piso_16 = false;
                if (PisoSiguiente.Ascensor1==16){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==15){
                Thread.Sleep(2000);
                piso_15.piso_15 = false;
                if (PisoSiguiente.Ascensor1==15){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==14){
                Thread.Sleep(2000);
                piso_14.piso_14 = false;
                if (PisoSiguiente.Ascensor1==14){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==13){
                Thread.Sleep(2000);
                piso_13.piso_13 = false;
                if (PisoSiguiente.Ascensor1==13){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            */
            
            //
            if (pisnum==12){
                Thread.Sleep(2000);
                piso_12.piso_12 = false;
                if (PisoSiguiente.Ascensor1==12){
                    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Bajando;
                    cuarto.GetComponent<Cuarto_Control>().llamada1=disponible1.origen;
                }
            }
            
            if (pisnum==11){
                Thread.Sleep(2000);
                piso_11.piso_11 = false;
                if (PisoSiguiente.Ascensor1==11){
                //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==10){
                Thread.Sleep(2000);
                piso_10.piso_10 = false;
                if (PisoSiguiente.Ascensor1==10){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==9){
                Thread.Sleep(2000);
                piso_9.piso_9 = false;
                if (PisoSiguiente.Ascensor1==9){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==8){
                Thread.Sleep(2000);
                piso_8.piso_8 = false;
                if (PisoSiguiente.Ascensor1==8){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==7){
                Thread.Sleep(2000);
                piso_7.piso_7 = false;
                if (PisoSiguiente.Ascensor1==7){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==6){
                Thread.Sleep(2000);
                piso_6.piso_6 = false;
                if (PisoSiguiente.Ascensor1==6){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==5){
                Thread.Sleep(2000);
                piso_5.piso_5 = false;
                if (PisoSiguiente.Ascensor1==5){
                //    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==4){
                Thread.Sleep(2000);
                piso_4.piso_4 = false;
                if (PisoSiguiente.Ascensor1==4){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==3){
                Thread.Sleep(2000);
                piso_3.piso_3 = false;
                if (PisoSiguiente.Ascensor1==3){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==2){
                Thread.Sleep(2000);
                piso_2.piso_2 = false;
                if (PisoSiguiente.Ascensor1==2){
                //    cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==1){
                Thread.Sleep(2000);
                piso_1.piso_1 = false;
                if (PisoSiguiente.Ascensor1==1){
                 //   cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                }
            }
            if (pisnum==0){
                Thread.Sleep(2000);
                piso_1.piso_1 = false;
                cuarto.GetComponent<Cuarto_Control>().Movi = MoviAscensor1.Subiendo;
                

            }
            

                    
        }
        
        
    }
   
}
