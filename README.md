### PUMA RUTAS          

#### Objetivos

- Desarrollar una aplicación  que permita a los estudiantes conocer el tiempo estimado de espera en una parada, así como el tiempo que tardarían en llegar a su destino y la ruta que más le conviene para facilitar la movilidad y la planificación de tiempos dentro de la universidad.

##### ¿Cómo funciona?
Se propuso tener una interfaz amigable para el usuario, ya que buscamos que no sea complicado buscar la parada en que te encuentras y a donde quieres llegar. De igual manera colocamos un mapa para que sea más facil ubicar la ruta deseada. 

##### Lenguaje de Programación
Decidimos trabar en **C#** ya que es un lenguaje muy completo en donde podemos encontrar:
- Facilidad de uso: C# se diseñó teniendo en cuenta la facilidad de uso. La sintaxis es limpia y fácil de entender, lo que facilita la lectura y escritura del código. Esto puede acelerar el proceso de desarrollo y reducir la probabilidad de errores.
-Seguridad: C# incorpora características de seguridad, como la administración automática de memoria a través del recolector de basura, lo que ayuda a prevenir problemas comunes como fugas de memoria.
- Rendimiento: C# es un lenguaje compilado que se ejecuta en la plataforma Common Language Runtime (CLR). Esto puede resultar en un rendimiento eficiente, especialmente cuando se compara con lenguajes interpretados. Además, se pueden utilizar técnicas de optimización y acceso a bibliotecas de bajo nivel para mejorar el rendimiento.
- Biblioteca estándar robusta: C# tiene una biblioteca estándar extensa y poderosa que proporciona una amplia gama de funcionalidades listas para usar. Esto permite a los desarrolladores realizar tareas comunes sin tener que escribir código desde cero.
-Desarrollo de aplicaciones para múltiples plataformas: Con el desarrollo de .NET Core, ahora llamado .NET 5 y versiones posteriores, C# se ha vuelto más versátil y se puede utilizar para desarrollar aplicaciones que se ejecuten en varias plataformas, incluyendo Windows, Linux y macOS.
- Soporte de la comunidad y documentación abundante: C# cuenta con una comunidad activa de desarrolladores y una amplia cantidad de recursos en línea, incluyendo documentación, tutoriales y foros de discusión. Esto facilita el aprendizaje y la resolución de problemas.

----------
#### Selección de Rutas y Paradas
La aplicación funciona con cinco paradas las cuales son:

1. Anexo de Ingeniería
1. FCA
1. Trabajo social
1. Metrobus CU
1. Metro CU

El formulario principal permite seleccionar una parada de incio y una parada de destino. Una vez escogidas ambas y confirmando en el botón, saltará una ventana donde podrás visualizar el tiempo estimado de espera, de llegada del pumabus y el numero correspondiente al pumabus que llegará a la parada donde te encuentras. En nuestro caso trabajamos con las rutas **2** y **4**

#### Visualización del mapa
El botón Mapa muestra como su nombre lo menciona un mapa de las rutas del pumabus en el campus universitario. Este mapa tiene la capacidad de acerca y alejar para una mejor visualización del mismo, ademas de permitir arrastra la imagen para ver distintas partes del mapa,
- [Rutas CU](https://www.dgsgm.unam.mx/pumabus.html) 
> Aquí puedes observar las diferentes rutas que existen en Ciudad Universitaria e idenitificar las que estan agregadas a la aplicación.

#### Cálculos de tiempos de espera y tiempos de llegada
El  formulario Pumarutas1 es el resultado final que muestra las rutas disponibles, los tiempos de espera estimados, los tiempos de llegada y el número de pumabus disponible para la ruta seleccionada entre la parada de incio y la parada de destino.

----------
#### Funcionalidades adicionales
- El código también incluye manejo de eventos de botones de "Atención" y "Home" para mostrar direcciones de correo electrónico y trasladarse entre formularios.


----------
![](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScZ0zK3eIrCg4M-IL4lEt1wSFO98-pCtEDRyjGT9Q_&s)
