P1: ¿Qué ha ocurrido en la ventana de Cambios de GIT?
Al añadir el control de código fuente, los archivos del proyecto han pasado a estar "rastreados" por Git. En la ventana aparecen todos los archivos con un icono de suma (+), indicando que son cambios pendientes de confirmar (staged) o que se han añadido nuevos archivos al repositorio local.

P2: ¿Qué sucede en la ventana de Cambios de GIT al ignorar las carpetas bin y obj?
Al seleccionar "Omitir estos elementos locales", se crea o modifica un archivo llamado .gitignore. Las carpetas bin y obj desaparecen de la lista de cambios pendientes, lo que evita que archivos temporales de compilación se suban al repositorio.

P3: ¿Qué ha ocurrido en la ventana de Cambios de GIT tras el primer commit?
La ventana de Cambios de GIT se queda vacía de cambios pendientes y muestra el mensaje "No hay cambios sin confirmar". Esto indica que el estado actual del código ha sido guardado en el historial del repositorio local.

P4: ¿Qué ha cambiado en el repositorio remoto tras hacer el primer Push?
En la web de GitHub, ahora aparecen todas las carpetas y archivos del proyecto (hada-p1, archivos .cs, .sln, etc.) que antes estaban solo en el ordenador. El repositorio remoto ahora coincide con el repositorio local.

P5: ¿Qué ha ocurrido al intentar hacer el Push después de modificar el README en la web y documentar el código en local?
El Push ha sido rechazado (Rejected). Esto ocurre porque el repositorio remoto tiene cambios (el archivo README.md) que no existen en el repositorio local, lo que genera un conflicto de historial que impide la subida directa.

P6: ¿Qué ha ocurrido tras realizar la operación de Extraer (Pull)?
Git ha descargado el archivo README.md desde GitHub y lo ha fusionado con los cambios locales. Ahora el repositorio local está actualizado con lo que había en la nube y ya permite realizar el Push de los cambios pendientes sin errores.

P7: ¿Qué cambios se observan en el repositorio remoto tras la Parte 7?
En GitHub ahora se puede ver una nueva rama llamada devel2, una nueva etiqueta (tag) v0.4 y, en la rama master, el código final que incluye el conversor de horas a minutos junto con toda la documentación XML.
