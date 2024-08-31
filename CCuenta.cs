using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBanco
{
    public class CCuenta
    {
       string nombre;
       string numeroDeCuenta;
        float saldo;

        public CCuenta(string nombre, string numeroDeCuenta, float saldo)
        {
            this.nombre = nombre;
            this.numeroDeCuenta = numeroDeCuenta;
            this.saldo = saldo;
        }


        public void setNombre(string nombre) {  this.nombre = nombre; }
        public void setSaldo(float saldo) { this.saldo = saldo; }
        public string getNombre() {  return this.nombre; }
        public string getNumeroDeCuenta() {  return this.numeroDeCuenta;}
        public float getSaldo() {  return this.saldo; }


        public void Depositar(float dinero)
        {
            if(dinero> 0)
            {
                saldo += dinero;
            }
            else
            {
                Console.WriteLine("NO SE PUEDE DEPOSITAR SALDO NEGATIVO");
            }
        }

        public void SacarDinero(float dinero)
        {
            if(this.saldo > dinero)
            {
                saldo -= dinero;
            }
            else
            {
                Console.WriteLine("SALDO INSUFICIENTE ");
            }
        }
        public override string ToString()
        {
            return "\n Nombre :"+ this.nombre + "\n Numero de Cuenta :" + this.numeroDeCuenta +"\n Saldo :" + this.saldo;
        }
        
    }
}
