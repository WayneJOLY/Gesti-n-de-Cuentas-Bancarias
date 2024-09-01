# 🏦 Programa de Gestión de Cuentas Bancarias

## Descripción
Este programa permite gestionar cuentas bancarias de manera sencilla y eficiente .
Esta Basado en Este Enunciado :
=============

 ------------
 En base al apunte “Clase Array en C#.pdf”, realice un programa que permita ingresar y registrar hasta 50 cuentas
bancarias, con sus correspondientes datos CBU, Cliente y Saldo, según el diseño establecido en la clase Cuenta (usada
en la clase 3).
Finalizado el proceso de registro al ingresar el máximo de 50 cuentas bancarias, o bien, al ingreso CBU: -1 (que no se
debe registrar y que no deberá solicitar naturalmente ni Cliente ni Saldo), el programa deberá solicitar y quedar a la
espera del ingreso de una CBU.
En caso de que la CBU corresponda a una cuenta previamente registrada, el programa deberá efectuar, sobre la
misma según las opciones que el usuario ingrese por teclado una extracción o un depósito.
Si, por el contrario, el valor ingresado de CBU a buscar no se correspondiera con ninguna cuenta previamente
ingresada, informarlo con el mensaje correspondiente.
Nuevamente, el programa deberá finalizar una vez que que usuario ingrese el valor -1. Al finalizar se debe mostrar la
información de todos los CBU con sus saldos correspondientes.

 ------------


## Funcionalidades

## ➡️Lo redujé  a esas funcions y se ve Mejor

- **Agregar una cuenta** 🆕: Permite registrar una nueva cuenta bancaria con la información del cliente y su saldo inicial.
- **Consultar el saldo de una cuenta** 💰: Facilita la consulta del saldo disponible en una cuenta específica.
- **Agregar dinero a una cuenta** ➕: Permite incrementar el saldo de una cuenta existente.
- **Sacar dinero de una cuenta** ➖: Permite retirar una cantidad de dinero de una cuenta, siempre que haya saldo suficiente.
- **Eliminar una cuenta** ❌: Permite eliminar una cuenta bancaria del registro.
- **Mostrar información de las cuentas** 📊: Muestra un resumen de todas las cuentas registradas, incluyendo CBU, nombre del cliente y saldo.
- **Salir** 🚪: Finaliza la ejecución del programa.

# Gestión de Cuentas:  COSAS QUE PODRIAS AGREGAR O MODIFICAR
- Crear nuevas cuentas bancarias.
- Eliminar cuentas existentes.
- Modificar detalles de las cuentas.

# Transacciones:
- Realizar depósitos en las cuentas.
- Efectuar retiros de las cuentas.
- Transferir fondos entre cuentas.

# Consultas:
- Ver el saldo actual de las cuentas.
- Consultar el historial de transacciones.

# Estructura del Programa:

## Clases Principales:
- **Cuenta**: Representa una cuenta bancaria con propiedades como número de cuenta, saldo, y métodos para realizar operaciones.
- **Transaccion**: Representa una transacción bancaria con detalles como tipo de transacción, monto y fecha.
- **Banco**: Gestiona las cuentas y las transacciones, proporcionando métodos para crear cuentas, realizar transacciones y consultar información.

## Interfaz de Usuario:
- Menú principal con opciones para gestionar cuentas y realizar transacciones.
- Validación de entradas del usuario para asegurar la integridad de los datos.

## Contribuciones
Las contribuciones son bienvenidas. Si deseas mejorar el programa, por favor sigue estos pasos:
1 - Realiza un fork del repositorio.
2 - Crea una nueva rama (git checkout -b feature/nueva-funcionalidad).
3 - Realiza tus cambios y haz commit (git commit -m 'Añadir nueva funcionalidad').
4 - Envía un pull request.
