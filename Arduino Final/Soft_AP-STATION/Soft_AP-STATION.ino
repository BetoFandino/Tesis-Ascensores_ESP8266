#include <ESP8266WiFi.h>

// Declaracion e inicializacion de variables utilizadas para la programación
// Datos para conectarse a una red wifi ya creada.
const char WiFiSSID[] = "Gedeon"; //SSID de la red Wifi//Conexión con mi red wifi desde la cual se puede crear un servidor para monitorear valores
const char WiFiPSK[] = "agosto1987";  //Contraseña WPA, WPA2 o WEP
const char WiFiAPPSK[] = "123";

//configuracion soft-AP
const char ssid[]="soft_ap";            // nombre de la red wifi creada
const char password[]="tesisusb1";      // contraseña de la red wifi creada


// Almacenamiento de las variables que guarda el piso
int piso;
String req= "0";
String valor1;

// Declaracion del objeto que actua como servidor y configura 
// el puerto 80 que es la que respondera a solicitudes HTTP
WiFiServer server(80);

void setup() 
{
  //Se inicializa el puerto serial a 115200 baudios
  Serial.begin(115200); 
  //Se configura y se realiza la conexion a la red Wifi
  connectWiFi();
  server.begin();
  
}

void loop() 
{
  Serial.println(req);
  // Se prueba si el dispositivo cliente ha realizado una solicitud
  WiFiClient client = server.available();
  if (!client) {
    return;
  }
  
  // Lectura de la primera linea de la solicitud
  req = client.readStringUntil('\r'); //Se lee la solicitud hasta \r
  
  //Serial.println(req); //Se muestra la solicitud realizada en el puerto Serial
  client.flush(); //Se descartan los datos que han sido escritos por el cliente pero aun no se leen
  
  
  int val = -1;
  if (req != NULL){  
    val = 0; 
    
    Serial.println(req); // se envia la respuesta del cliente al puerto serial.
  }
  

  
  
  delay(50);
  

}


void connectWiFi()
{
  
  WiFi.mode(WIFI_AP_STA);
  WiFi.softAP(ssid, password, 1, false, 2);

  WiFi.begin(WiFiSSID, WiFiPSK);

   while (WiFi.status() != WL_CONNECTED) 
  {
    delay(100); 
   Serial.print('.');
  }
  
  //Serial.println("WiFi connected");
  //Serial.println("IP address: ");
  //Serial.println(WiFi.localIP());
}
