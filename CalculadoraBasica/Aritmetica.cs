using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//En esta clase estan los metodos que realizan las operaciones basicas de una calculadora
namespace CalculadoraBasica
{
    class Aritmetica
    {

        private double num1;
        private double num2;
        private double resultado;
        //Metodo constructor vacio
        public Aritmetica()
        {
        }
        //Metodo constructor(Sobrecarga del metodo constructor)
        public Aritmetica(double num1, double num2, double resultado)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.resultado = resultado;
        }

        //Metodos get y set
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }
        public void setNum2(double num2)
        {
            this.num2 = num2;
        }
        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        //Metodo que realiza la operacion sumar
        public double sumar(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
            
            this.resultado = this.num1 + this.num2 ;

            return this.resultado;

        }
        //Metodo que realiza la operacion restar
        public double restar(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;

            this.resultado = this.num1 - this.num2;

            return this.resultado;

        }
        //metodo que realiza la operacion multiplicar
        public double multiplicar(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;

            this.resultado = this.num1 * this.num2;

            return this.resultado;

        }

        //metodo que realiza la operacion dividir
        public double dividir(double num1, double num2)
        {
            //Este try catch impide que la aplicacion se cierre al dividir un numero entre cero
          try
            {
                this.num1 = num1;
                this.num2 = num2;

                this.resultado = this.num1 / this.num2;

                

            }
            catch(DivideByZeroException e)
            {
                resultado = 00;
            }
            return this.resultado;
        }

            

        }





    }

