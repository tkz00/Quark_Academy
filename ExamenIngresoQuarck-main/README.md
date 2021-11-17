# ExamenIngresoQuarck

Pasos para iniciar el programa

1. Abrir el CotizadorExpress.exe en la raiz del proyecto

PARTE H

Por favor, especifica tu nombre completo: Franco Delocca

Preguntas:

1. ¿C# permite herencia múltiple?
2. ¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
3. ¿Qué implica una relación de Generalización entre dos clases?
4. ¿Qué implica una relación de Implementación entre una clase y una interfaz?
5. ¿Qué diferencia hay entre la relación de Composición y la Agregación?
6. Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

    a. Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.

    b. Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 

    c. Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 

Respuestas:

1. C# no permite herencia múltiple.

2. Se tiene que usar una clase abstracta cuando tenemos una jerarquia de clases Ejemplo: Tenemos la la clase abstracta vehiculo tiene como atributo cantidadDeRuedas y tenemos que conservar ese atributo en las clases hijas como auto o camion, algo que con la interfaz no se puede, pero por otro lado podemos usar tambien una interfaz para definir el comportamiento de esos vehiculos. Las interfaces no permiten atributos, como cantidadDeRuedas.

3. La generalizacion es una relacion entre un elemento padre y un elemento hijo.

4. Implica que esta definiendo como se va a comportar esa clase.

5. La diferencia es que en la agregacion si el objeto "todo2 fuera eliminado los objetos vinculados seguirian existiendo, en cambio la asociacion si el objeto "todo" es eliminado los vinculos tambien.

6. 
    A. V
    B. F
    C. F