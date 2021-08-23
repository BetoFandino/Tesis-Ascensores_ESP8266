
#include <ESP8266WiFi.h>
#include <Keypad.h>


// Declaracion e inicializacion de variables utilizadas para
// realizar la conexion a la red Wifi local
const char WiFiSSID[] = "soft_ap"; //cambia macID por el ID del dispositivo servidor
const char WiFiPSK[] = "tesisusb1";      // contraseña de la red lan dada por el modulo en modo Soft_AP

int j=0;
String url;
const byte filas = 4; 
const byte columnas = 4;
byte pinesFilas[filas] = {5, 4, 0, 2}; 
byte pinesColumnas[columnas] = {14, 12, 13, 15};
char teclas[4][4] = {{'1','2','3','A'},
                     {'4','5','6','B'},
                     {'7','8','9','C'},
                     {'*','0','#','D'}};

Keypad teclado1 = Keypad(makeKeymap(teclas), pinesFilas, pinesColumnas, filas, columnas);
// Informacion de nuestro servidor
const char host[] = "192.168.4.1"; //Direccion IP de nuestro servidor
const int httpPort = 80; //Puerto de enlace


char piso1[2];
String macID; //String donde se almacenara nuestra macID
//Variables donde se almacenan el piso solicitado.
int value1;

void setup() {
  initHardware(); // Inicializammos nuestros pines fisicos
  connectWiFi();  // Conexion nuestra red Wifi
}

void loop() {
  delay(1000); 
  
   ////////////////////////////////////////////////////////////// 
  // TECLADO
  //Verifica si alguna tecla fue presionada
   //Serial.println("Que piso quieres?");
   
   while(j != 2){         // Verifica que se han colocado dos botones para ir del piso 00 al piso 20
    char tecla_presionada = teclado1.getKey();
    if (tecla_presionada!= NO_KEY)
      {
        j++;
        url += tecla_presionada;
        Serial.print("Tecla: ");
        Serial.println(tecla_presionada);
        Serial.print("Piso: ");
        Serial.println(url);
      }
      
      else if (tecla_presionada == NO_KEY){
        return;
        
      }
    }

   WiFiClient client;                       // se entabla conexión de manera cliente
   if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    return;
   }
    

  
  Serial.print("Requesting URL: ");
  Serial.println(url);
  url += ",A2";                       // se le agrega un codigo especial para diferenciar de que ascensor se envio la solicitud de piso
                                    // Se envia la solicitud al servidor
  client.print(url);
  url.clear();
  j=0;
 
  ////////////////////////////////////////////////////////////////
  
 
  
  
  

  unsigned long timeout = millis();
  while (client.available() == 0) {
    if (millis() - timeout > 1000) {
      Serial.println(">>> Client Timeout !");
      client.stop();
      return;
    }
  }
  
  
  Serial.println();
  Serial.println("closing connection");

 
}

void connectWiFi()
{
  
  // We start by connecting to a WiFi network
  Serial.println();
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(WiFiSSID);
  
  // Configuramos nuestro dispositivo IoT como estacion
  WiFi.mode(WIFI_STA);

  // Se inicia la conexion a nuestro servidor ESP8266 Thing + macID
  WiFi.begin(WiFiSSID, WiFiPSK);

  // Se espera a que nuestro ESP8266 se conecte a la red Wifi local
  byte ledStatus = LOW;
  while (WiFi.status() != WL_CONNECTED)
  {
    // Blink 
    Serial.print(".");
    
    delay(100);
  }
  Serial.println("WiFi connected");  
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

void initHardware()
{
  Serial.begin(115200); //Inicializacion y configuracion de puerto serial
  
}
