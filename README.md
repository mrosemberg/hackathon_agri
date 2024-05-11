El Gremio de Agricultores (GRAMA) en conjunto con la Dirección de meteorología de la región, están trabajando para encontrar una solución a las perdidas de cultivos ocasionadas por el cambio abrupto del clima de la región. Es por esto, que se pone en contacto con ustedes para desarrollar una página que permita alertar a los productores sobre posibles fenómenos meteorológicos que perjudiquen la producción..

Requerimientos funcionales
Descripción General: Desarrollar y diseñar una página web que permita mostrar a los productores, el pronóstico extendido de los departamentos estudiados en el país, que por el momento son: Central, Boquerón, Caaguazú.

El usuario debe ser capaz de seleccionar un departamento y poder visualizar el pronóstico extendido.
La página debe estar preparada para mostrar más departamentos a medida que se vayan obteniendo los datos en un futuro.
El pronóstico extendido debe mostrar todas las variables meteorológicas obtenidas: temperatura, clima, viento, visibilidad, probabilidad de precipitación y el volumen de lluvia predicho.
El diseño de la página debe contar con imágenes alusivas al estado del tiempo. Los posibles valores esperados son (nublado_total, soleado, lluvia, tormenta_electrica, nublado_parcialemente, nieve). Por supuesto, se espera de la creatividad del diseñador para mostrar cada una de la variables meteorológicas que se tienen lectura de una forma concisa y entendible.
El pronóstico extendido además, debe mostrar los tipos de alerta, que deberá ser calculada en base a las variables meteorológicas por cada día. Estas alertas servirán como ayuda a los productores para tomar decisiones con respecto a sus cultivos.
El tipo de alerta está categorizada de la siguiente manera:
óptimo: indica que la combinación de las variables meteorológicas es la ideal para el cultivo.
precaución: indica que la combinación de las variables meteorológicas puede ser perjudicial si no se toman medidas preventivas.
peligroso: indica que la combinación de las variables meteorológicas tiene grandes probabilidades de provocar daños irreparables del cultivo.
La página debe poder adaptarse a las distintas resoluciones de pantalla.
Si bien se cuenta con un mockup básico de lo que se espera ver en la página web. También se espera que el equipo de desarrolladores sea capaz de mejorar la idea inicial, siempre tomando en cuenta el objetivo de la página, que consiste en comunicar de una manera fácil e intuitiva a los productores sobre los posibles cambios climáticos abruptos que puedan ocurrir en la región.
Cálculos solicitados

Grados Fahrenheit: Se espera que la temperatura pueda visualizarse en grados Celsius y Fahrenheit. (Fahrenheit debe ser calculado en base al celsius).
Tipos de Alerta: El criterio para calcular los tipo de alertas dependerá de cada equipo, tomando en cuenta las variables extraídas del API. Formará como parte de la evaluación del desafío, la creatividad y la complejidad aplicada a este calculo. Para eso, se solicita a cada equipo implementar el método getAlertType(array weatherDataPerDay) return string;, que calcule y devuelva como resultado el tipo de alerta (óptimo, precaución, peligroso) correspondiente a un día, que será recibida como entrada del método.
