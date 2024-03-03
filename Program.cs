/* 1 */

Console.WriteLine("Calculadora de fracciones");
Console.WriteLine("Ingrese el numerador de la fraccion 1: ");
float numerador1= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el denominador de la fraccion 1: ");
float denominador1= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Operador (+ - X / )");
String operador = Console.ReadLine();

Console.WriteLine("Ingrese el numerador de la fraccion 2: ");
float numerador2= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el denominador de la fraccion 2: ");
float denominador2= int.Parse(Console.ReadLine());

float suma= ((numerador1 * denominador2)+(numerador2*denominador1))/(denominador1*denominador2);
float resta=((numerador1 * denominador2)-(numerador2*denominador1))/(denominador1*denominador2);
float multiplicacion = (numerador1*numerador2)/(denominador1*denominador2);
float division= (numerador1*denominador2)/(numerador2/denominador1);


if (denominador1 != 0 && denominador2 !=0 ){
    if (operador == "+"){
    Console.WriteLine("El resultado de la suma es: "+ suma);

}else

 if(operador == "-"){
    Console.WriteLine("El resultado de la resta es: " + resta);

}else 

if (operador == "x"){
    Console.WriteLine("El resultado de la multiplicación es: "+ multiplicacion);

}else 

    if(operador == "/"){
        Console.WriteLine("El resultado de la división es: "+ division);
    }

} else{

    Console.WriteLine("Error no se puede dividir por 0");

}

/* 2 */

Console.WriteLine("***Número especial***");

Console.WriteLine("Ingrese un número");
int numero= int.Parse(Console.ReadLine());

if (numero % 5 ==0){

    if(numero % 2 !=0 && numero % 3 !=0){
        Console.WriteLine("El número es especial");

    }else{

        Console.WriteLine("El numero no especial");
    }
} 

/* 3 */

Console.WriteLine("Días y semana");

Console.WriteLine("Ingrese la edad actual");
int edad = int.Parse(Console.ReadLine());

int dias= edad * 365;
int semanas = edad * 52;

int Bisiestos = edad/4;
dias= Bisiestos + dias;

Console.WriteLine("Su edad es: " + edad);
Console.WriteLine("Los dias trascurridos son: " + dias);
Console.WriteLine("Las semanas trascurridas son: "+ semanas);

/* 4 */

Console.WriteLine("Sistema de inicio de sesión ");

String Usuario= "user123";
String Contraseña ="U0918";
int intentos= 3;

while (intentos > 0){
    Console.WriteLine("Ingrese su usuario: ");
    String User = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña: ");
    String Password= Console.ReadLine();
     

      if (Usuario == User && Contraseña==Password){
        Console.WriteLine("Acceso concedido");
        break;

}else{
    intentos --;
    if(intentos > 0){
        
      Console.WriteLine("Los datos no son correctos");
      Console.WriteLine("Tiene " + intentos + " intentos");

    }else{

        Console.WriteLine("Acceso denegado");
    }
  }
}

