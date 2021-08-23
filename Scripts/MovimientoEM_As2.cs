using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.IO.Ports;
using UnityEngine.UI;

public class MovimientoEM_As2 : MonoBehaviour
{
   public int PisoActual=0;
    //public int PisoSiguiente=0;
    public CuartoControlEmpre PisoSiguiente;
    public CuartoControlEmpre piso_0;
    public CuartoControlEmpre piso_1;
    public CuartoControlEmpre piso_2;
    public CuartoControlEmpre piso_3;
    public CuartoControlEmpre piso_4;
    public CuartoControlEmpre piso_5;
    public CuartoControlEmpre piso_6;
    public CuartoControlEmpre piso_7;
    public CuartoControlEmpre piso_8;
    public CuartoControlEmpre piso_9;
    public CuartoControlEmpre piso_10;
    public CuartoControlEmpre piso_11;
    public CuartoControlEmpre piso_12;
    public CuartoControlEmpre piso_13;
    public CuartoControlEmpre piso_14;
    public CuartoControlEmpre piso_15;
    public CuartoControlEmpre piso_16;
    public CuartoControlEmpre piso_17;
    public CuartoControlEmpre piso_18;
    public CuartoControlEmpre piso_19;
    public CuartoControlEmpre piso_20;

   

    public Text numPiso;

    public GameObject cuarto;
    public GameObject Ascen1;

    public int pisnum=0;

    
    // Start is called before the first frame update
    void Start()
    {
        PisoSiguiente = FindObjectOfType<CuartoControlEmpre>(); // se lee el valor del piso solicitado que llego del script de cuarto de control
        piso_0 = FindObjectOfType<CuartoControlEmpre>();
        piso_1 = FindObjectOfType<CuartoControlEmpre>();
        piso_2 = FindObjectOfType<CuartoControlEmpre>();
        piso_3 = FindObjectOfType<CuartoControlEmpre>();
        piso_4 = FindObjectOfType<CuartoControlEmpre>();
        piso_5 = FindObjectOfType<CuartoControlEmpre>();
        piso_6 = FindObjectOfType<CuartoControlEmpre>();
        piso_7 = FindObjectOfType<CuartoControlEmpre>();
        piso_8 = FindObjectOfType<CuartoControlEmpre>();
        piso_9 = FindObjectOfType<CuartoControlEmpre>();
        piso_10 = FindObjectOfType<CuartoControlEmpre>();
        piso_11 = FindObjectOfType<CuartoControlEmpre>();
        piso_12 = FindObjectOfType<CuartoControlEmpre>();
        piso_13 = FindObjectOfType<CuartoControlEmpre>();
        piso_14 = FindObjectOfType<CuartoControlEmpre>();
        piso_15 = FindObjectOfType<CuartoControlEmpre>();
        piso_16 = FindObjectOfType<CuartoControlEmpre>();
        piso_17 = FindObjectOfType<CuartoControlEmpre>();
        piso_18 = FindObjectOfType<CuartoControlEmpre>();
        piso_19 = FindObjectOfType<CuartoControlEmpre>();
        piso_20 = FindObjectOfType<CuartoControlEmpre>();


    }

    // Update is called once per frame
    void Update()
    {
        numPiso.text = "Piso ascensor 2: " + PisoActual.ToString();
        pisnum = PisoSiguiente.Ascensor2;
        
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_19.piso_19 == true){
                pisnum = 19;
            } 
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_18.piso_18 == true){
                pisnum = 18;
            } 
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_17.piso_17 == true){
                pisnum = 17;
            } 
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_16.piso_16 == true){
                pisnum = 16;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_15.piso_15 == true){
                pisnum = 15;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_14.piso_14 == true){
                pisnum = 14;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_13.piso_13 == true){
                pisnum = 13;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_12.piso_12 == true){
                pisnum = 12;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_11.piso_11 == true){
                pisnum = 11;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_10.piso_10 == true){
                pisnum = 10;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_9.piso_9 == true){
                pisnum = 9;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_8.piso_8 == true){
                pisnum = 8;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_8.piso_8 == true){
                pisnum = 8;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_7.piso_7 == true){
                pisnum = 7;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_6.piso_6 == true){
                pisnum = 6;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_5.piso_5 == true){
                pisnum = 5;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_4.piso_4 == true){
                pisnum = 4;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_3.piso_3 == true){
                pisnum = 3;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_2.piso_2 == true){
                pisnum = 2;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_1.piso_1 == true){
                pisnum = 1;
            }  
            if(cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB && piso_0.piso_0 == true){
                pisnum = 0;
            }  
        if(PisoSiguiente.Ascensor2<pisnum){
            pisnum=PisoSiguiente.Ascensor2;
        }
           
        
        if (pisnum>PisoActual && cuarto.GetComponent<CuartoControlEmpre>().Movi2 == MoviAscensor2E.Subiendo){ //para subir el ascensor
            //Debug.Log("Subiendo");
            PisoActual++;
            transform.position = new Vector3(transform.position.x,PisoActual/2,transform.position.z);
            Thread.Sleep(500);
            cuarto.GetComponent<CuartoControlEmpre>().llamada2=disponible2E.noallegado;                        
        }

        if (pisnum<PisoActual && cuarto.GetComponent<CuartoControlEmpre>().Estado2 == EstadoAscensor2E.SubirB ){    // para bajar el ascensor  
            //Debug.Log("Bajando");
            PisoActual--; 
            transform.position = new Vector3(transform.position.x,PisoActual/2,transform.position.z);
            Thread.Sleep(500);
            cuarto.GetComponent<CuartoControlEmpre>().llamada2=disponible2E.noallegado;                                       
        }
        if (PisoActual == pisnum){
            if(cuarto.GetComponent<CuartoControlEmpre>().llamada2!=disponible2E.origen){
                cuarto.GetComponent<CuartoControlEmpre>().llamada2=disponible2E.llego;
            }
            
            //cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
            if (pisnum==20){
                Thread.Sleep(20000);
                cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                piso_20.piso_20 = false;
                
            }
            if (pisnum==19){
                Thread.Sleep(20000);
                piso_19.piso_19 = false;
                if (PisoSiguiente.Ascensor1==19){
                   // cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==18){
                Thread.Sleep(20000);
                piso_18.piso_18 = false;
                if (PisoSiguiente.Ascensor1==18){
                  //  cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==17){
                Thread.Sleep(20000);
                piso_17.piso_17 = false;
                if (PisoSiguiente.Ascensor1==17){
                   // cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==16){
                Thread.Sleep(20000);
                piso_16.piso_16 = false;
                if (PisoSiguiente.Ascensor1==16){
                   // cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==15){
                Thread.Sleep(20000);
                piso_15.piso_15 = false;
                if (PisoSiguiente.Ascensor1==15){
                    //cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==14){
                Thread.Sleep(20000);
                piso_14.piso_14 = false;
                if (PisoSiguiente.Ascensor1==14){
                    //cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==13){
                Thread.Sleep(20000);
                piso_13.piso_13 = false;
                if (PisoSiguiente.Ascensor1==13){
                    //cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            
            if (pisnum==12){
                Thread.Sleep(20000);
                piso_12.piso_12 = false;
                //if (PisoSiguiente.Ascensor1==12){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                //}
            }
            
            if (pisnum==11){
                Thread.Sleep(20000);
                piso_11.piso_11 = false;
                //if (PisoSiguiente.Ascensor1==11){
                //   cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                //}
            }
            if (pisnum==10){
                Thread.Sleep(20000);
                piso_10.piso_10 = false;
                if (PisoSiguiente.Ascensor1==10){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==9){
                Thread.Sleep(20000);
                piso_9.piso_9 = false;
                if (PisoSiguiente.Ascensor1==9){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==8){
                Thread.Sleep(20000);
                piso_8.piso_8 = false;
                if (PisoSiguiente.Ascensor1==8){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==7){
                Thread.Sleep(20000);
                piso_7.piso_7 = false;
                if (PisoSiguiente.Ascensor1==7){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==6){
                Thread.Sleep(20000);
                piso_6.piso_6 = false;
                if (PisoSiguiente.Ascensor1==6){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==5){
                Thread.Sleep(20000);
                piso_5.piso_5 = false;
                if (PisoSiguiente.Ascensor1==5){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==4){
                Thread.Sleep(20000);
                piso_4.piso_4 = false;
                if (PisoSiguiente.Ascensor1==4){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==3){
                Thread.Sleep(20000);
                piso_3.piso_3 = false;
                if (PisoSiguiente.Ascensor1==3){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==2){
                Thread.Sleep(20000);
                piso_2.piso_2 = false;
                if (PisoSiguiente.Ascensor1==2){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==1){
                Thread.Sleep(20000);
                piso_1.piso_1 = false;
                if (PisoSiguiente.Ascensor1==1){
                //    cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Bajando;
                }
            }
            if (pisnum==0){
                Thread.Sleep(20000);
                piso_1.piso_1 = false;
                cuarto.GetComponent<CuartoControlEmpre>().Movi2 = MoviAscensor2E.Subiendo;
                cuarto.GetComponent<CuartoControlEmpre>().llamada2=disponible2E.origen;
                

            }
            

                    
        }
   
        
        
    }
}