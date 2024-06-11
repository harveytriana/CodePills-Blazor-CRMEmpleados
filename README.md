# CodePills-Blazor-CRMEmpleados

Acerca de la presentación de **Garaje de ideas | Tech**, [Creamos la misma aplicación con ReactJS y Angular y te contamos las diferencias](https://www.youtube.com/watch?v=0uS3VL_auNU), me pregunté cómo se vería el mismo proyecto en Blazor. Más allá del mundo JS, y de la sofisticación con TS, Blazor Web Assembly es una alternativa. 

Blazor se parece más a Angular que a REACT. No obstante, es adaptable a ambos mundos. Podemos hacer una arquitectura similar, en cualquier caso. Me enfoque en la perspectiva Angular. Se aplican los mismos conceptos.

Una diferencia de forma es que los objetos en C# los describimos en norma Pascal, entonces se decoran para que sigan las reglas de JS y así poder consumir la misma API.

Similar a Angular, los componentes se pueden dividir en los tres archivos HTML con marcado, estilos (CSS), y código; por supuesto, en este caso es C# en vez de TS. O, si se prefiere todo en uno solo. Dejé los componentes divididos para asemejar equivalencia a Angular.

En este proyecto no usé ninguna dependencia de terceros, solo el entorno que ofrece Blazor. No existe una sola línea JS. La interfaz de usuario está en español, cómo en los originales de las otras tecnologías, pero todo el código en inglés.

<sup>Luis Harvey Triana Vega.<br>Software Engineer</sup>

## Epilogo

> Me han preguntado ¿Qué ventajas tendría Blazor WA sobre las tecnologías JS en general? Enumero.

- Se escribe menos código
- Realmente reactivo o, en otras palabras, inherentemente reactivo.
- Compilado real (no transposición a JS como lo hace Svelte)
- Sin DOM virtual (no lo necesita)
- La aplicación creada es WASM sin desarrollo excesivamente complejo; como lo están intentando hacer otros. 
- Escribes en un lenguaje fuertemente tipado de alto nivel.
- Puede usar poderosas librerías binarias, por ejemplo Skia a través de SkiaSharp.
- Mismo lenguaje y reglas frente al backend, puedes compartir en referencia las mismas librerías de modelos.
- Puedes usar componentes nativos en otros lenguajes como Rust, C++, o C. 



