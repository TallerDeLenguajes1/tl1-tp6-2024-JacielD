1) String es una tipo por valor o un tipo por referencia?

. string es un valor por referencia

2) ¿Qué secuencias de escape tiene el tipo string?

. string tiene las siguientes secuencias de escape:

    \n: representa un salto de línea.
    \t: representa un tabulador.
    \\: representa una barra invertida.
    \': representa una comilla simple.
    \": representa una comilla doble.
    \r: representa un retorno de carro.
    \b: representa un retroceso.
    \f: representa un avance de página.

3) ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

.El carácter "@" antes de una cadena de texto en C# se utiliza para indicar que la cadena es una cadena literal, lo que significa que los caracteres de escape dentro de la cadena no se procesarán. Por ejemplo, @"\n" representa la cadena "\n" tal como está escrita, sin interpretar el carácter de salto de línea.

Al utilizar el símbolo "$" antes de una cadena de texto en C#, se pueden incluir variables y expresiones dentro de la cadena colocándolas entre llaves "{}". Estas expresiones son evaluadas y su resultado se inserta en la cadena en el lugar correspondiente.