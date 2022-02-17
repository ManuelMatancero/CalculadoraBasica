using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
    //Esta es la clase principal de los eventos del programa
{
    public partial class Form1: Form
    {
        //Serie de variables que me permiten controlar ciertas funciones del programa
        double num1 ;
        double num2 ;
        string signo;
        bool cambio=true;
        bool clic = true;

        public Form1()
        {
            InitializeComponent();
        }
        //Aqui instancio la clase Aritmetica
        Aritmetica aritmetica = new Aritmetica();

        //Acciones para el boton 1
        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (cambio==true)
            {
                txtres.AppendText("1");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("1");
                cambio = true;
             
            }    
                   
        }
        //Acciones para el boton 2
        private void btn2_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("2");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("2");
                cambio = true;
            }

        }
        //Acciones para el boton 3
        private void btn3_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("3");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("3");
                cambio = true;
            }

        }
        //Acciones para el boton 4
        private void btn4_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("4");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("4");
                cambio = true;
            }

        }
        //Acciones para el boton 5
        private void btn5_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("5");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("5");
                cambio = true;
            }

        }
        //Acciones para el boton 6
        private void btn6_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("6");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("6");
                cambio = true;
            }

        }
        //Acciones para el boton 7
        private void btn7_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("7");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("7");
                cambio = true;
            }

        }
        //Acciones para el boton 8
        private void btn8_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("8");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("8");
                cambio = true;
            }

        }
        //Acciones para el boton 9
        private void btn9_Click(object sender, EventArgs e)
        {
            if (cambio == true)
            {
                txtres.AppendText("9");
            }
            else
            {
                txtres.Clear();
                txtres.AppendText("9");
                cambio = true;
            }

        }
        //Acciones para el boton 0
        private void btn0_Click(object sender, EventArgs e)
        {
            //Si el cuadro te texto contiene un cero no me permite agregar mas
            if (txtres.Text.Equals("0"))
            {

            }
            else
            {
                if (cambio == true)
                {
                    txtres.AppendText("0");
                }
                else
                {
                    txtres.Clear();
                    txtres.AppendText("0");
                    cambio = true;
                }
            } 
            
            
        }
        //Acciones para el boton punto 
        private void btnpunto_Click(object sender, EventArgs e)
        {
            string texto = txtres.Text;
            //En este caso si el cuadro de texto es igual a cadena vacia no me permite agregar puntos
            if (texto.Equals(""))
            {

            }
            else
            {
                //Para evitar introducir mas de un punto el boton se desabilita para evitar posibles errores
                txtres.AppendText(".");
                btnpunto.Enabled=false;
            }

        }
        //Acciones para el boton borrar 
        private void btnborrar_Click(object sender, EventArgs e)
        {
            //Este try es para evitar que el programa se cierre cuando intentemos borrar 
            //con el cuadro de texto vacio o sea sin numeros
            try
            {
                //Este codigo me permite que los numeros se eliminen uno a uno
                string number = txtres.Text;
                int largo = (number.Length - 1);
                string number2 = number.Remove(largo, 1);
                txtres.Text = number2;

                //Si el cuadro de tecto es igual a cadena vacia se activa el boton punto
                if (txtres.Text.Equals(""))
                {
                    btnpunto.Enabled = true;
                }

            } catch (ArgumentOutOfRangeException exec)
            {

            }         

        }

        //Acciones para el boton reset llamado AC 
        private void btnreset_Click(object sender, EventArgs e)
        {
            //Este codigo habilita reinicia las funciones del programa y le da valor de 0 a cada atributo del objeto
            txtres.Text = string.Empty;
            btnpunto.Enabled = true;
            aritmetica.setNum1(0);
            aritmetica.setNum2(0);
            aritmetica.setResultado(0);
            clic = true;
            cambio = true;

        }
        //Aciones para el boton sumar
        private void btnmas_Click(object sender, EventArgs e)
        {
           
            //Estas operaciones me permiten obtener el resultado de las sumas cuando se estan sumando mas de 2 numeros
            if (clic==true)
            {
                num1 = Double.Parse(txtres.Text);
                signo = "+";
                btnpunto.Enabled = true;
                txtres.Clear();
                //cambio = false;
                clic = false;
            }
            
            else if(signo.Equals("+"))
            {
                num2 = Double.Parse(txtres.Text);
                signo = "+";
                btnpunto.Enabled = true;
                txtres.Clear();
                cambio = false;
                txtres.Text = Convert.ToString(aritmetica.sumar(num1, num2));
                num1 = aritmetica.getResultado();

                //////////////////////////////////////////////////////////////////////////
            }
            //Estas operaciones entraran en accion en caso de que el usuario halla estado realizando cualquier otra operacion que no
            //sea suma y de click en el boton sumar esto completara la operacion anterior dependiendo de que operacion venga.
            //se puede entender mas con la variable signo dependiendo que operacion tenga almacenada la terminara de realizar dando su resultado
            //y continuara realizando la operacion en la que se encuentra ya que el signo cambiara de valor a la operacion correspondiente
            //en este boton 
            else
            {
                if (signo.Equals("-"))
                {
                    signo = "+";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.restar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
                else if (signo.Equals("*"))
                {
                    signo = "+";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.multiplicar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
                else if (signo.Equals("/"))
                {
                    signo = "+";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.dividir(num1, num2));
                    num1 = aritmetica.getResultado();
                }
            }
                   
        }
        //Acciones para el boton restar 
        private void btnmenos_Click(object sender, EventArgs e)
        {
            //Estas operaciones me permiten obtener el resultado de las sumas cuando se estan restando mas de 2 numeros
            if (clic == true)
            {
                num1 = Double.Parse(txtres.Text);
                signo = "-";
                btnpunto.Enabled = true;
                txtres.Clear();
                //cambio = false;
                clic = false;
            }
            else if (signo.Equals("-"))
            {
                num2 = Double.Parse(txtres.Text);
                signo = "-";
                btnpunto.Enabled = true;
                txtres.Clear();
                cambio = false;
                txtres.Text = Convert.ToString(aritmetica.restar(num1, num2));
                num1 = aritmetica.getResultado();

                ////////////////////////////////////////////////////////////////////////////

                //Estas operaciones entraran en accion en caso de que el usuario halla estado realizando cualquier otra operacion que no
                //sea resta y de click en el boton restar esto completara la operacion anterior dependiendo de que operacion venga.
                //se puede entender mas con la variable signo dependiendo que operacion tenga almacenada la terminara de realizar dando su resultado
                //y continuara realizando la operacion en la que se encuentra ya que el signo cambiara de valor a la operacion correspondiente
                //en este boton 
            }
            else 
            {
                if (signo.Equals("+"))
                {
                    signo = "-";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.sumar(num1, num2));
                    num1 = aritmetica.getResultado();
                }else if (signo.Equals("*"))
                {
                    signo = "-";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.multiplicar(num1, num2));
                    num1 = aritmetica.getResultado();
                }else if (signo.Equals("/"))
                {
                    signo = "-";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.dividir(num1, num2));
                    num1 = aritmetica.getResultado();
                }
            
            }

        }
        //Acciones para el boton multiplicar
        private void btnpor_Click(object sender, EventArgs e)
        {
            //Estas operaciones me permiten obtener el resultado de la multiplicacion cuando se estan multiplicando mas de 2 numeros
            if (clic == true)
            {
                num1 = Double.Parse(txtres.Text);
                signo = "*";
                btnpunto.Enabled = true;
                txtres.Clear();
                //cambio = false;
                clic = false;
            }
            else if(signo.Equals("*"))
            {
                num2 = Double.Parse(txtres.Text);
                signo = "*";
                btnpunto.Enabled = true;
                txtres.Clear();
                cambio = false;
                txtres.Text = Convert.ToString(aritmetica.multiplicar(num1, num2));
                num1 = aritmetica.getResultado();

            }
            ///////////////////////////////////////////////////////////////////////////////////
            ///
            //Estas operaciones entraran en accion en caso de que el usuario halla estado realizando cualquier otra operacion que no
            //sea multiplicacion y de click en el boton multiplicar esto completara la operacion anterior dependiendo de que operacion venga.
            //se puede entender mas con la variable signo dependiendo que operacion tenga almacenada la terminara de realizar dando su resultado
            //y continuara realizando la operacion en la que se encuentra ya que el signo cambiara de valor a la operacion correspondiente
            //en este boton 
            else
            {
                if (signo.Equals("-"))
                {
                    signo = "*";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.restar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
                else if (signo.Equals("+"))
                {
                    signo = "*";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.sumar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
                else if (signo.Equals("/"))
                {
                    signo = "*";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.dividir(num1, num2));
                    num1 = aritmetica.getResultado();
                }
            }

        }

        //Acciones para el boton dividir
        private void btnentre_Click(object sender, EventArgs e)
        {
            //Estas operaciones me permiten obtener el resultado de la division cuando se estan dividiendo mas de 2 numeros
            if (clic == true)
            {
                num1 = Double.Parse(txtres.Text);
                signo = "/";
                btnpunto.Enabled = true;
                txtres.Clear();
               // cambio = false;
                clic = false;
            }
            else if (signo.Equals("/"))
            {
                num2 = Double.Parse(txtres.Text);
                signo = "/";
                btnpunto.Enabled = true;
                txtres.Clear();
                cambio = false;
                txtres.Text = Convert.ToString(aritmetica.dividir(num1, num2));
                num1 = aritmetica.getResultado();

            }
            /////////////////////////////////////////////////////////////////////////////////////
            ///
            //Estas operaciones entraran en accion en caso de que el usuario halla estado realizando cualquier otra operacion que no
            //sea division y de click en el boton dividir esto completara la operacion anterior dependiendo de que operacion venga.
            //se puede entender mas con la variable signo dependiendo que operacion tenga almacenada la terminara de realizar dando su resultado
            //y continuara realizando la operacion en la que se encuentra ya que el signo cambiara de valor a la operacion correspondiente
            //en este boton 
            else
            {
                if (signo.Equals("-"))
                {
                    signo = "/";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.restar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
                else if (signo.Equals("*"))
                {
                    signo = "/";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.multiplicar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
                else if (signo.Equals("+"))
                {
                    signo = "/";
                    btnpunto.Enabled = true;
                    txtres.Clear();
                    cambio = false;
                    txtres.Text = Convert.ToString(aritmetica.sumar(num1, num2));
                    num1 = aritmetica.getResultado();
                }
            }

        }

        //Acciones para el boton igial 
        private void btnigual_Click(object sender, EventArgs e)
        {
            //Aqui si el cuadro de texto esta vacio no se realizara ninguna accion
            if (txtres.Text.Equals(""))
            {

            }
            //En el caso contrario num 2 tomara el valor que se encuentre en el cuadro de texto
            // y con la sentencia switch verifica que valor tiene la variable signo y realizara 
            //la accion correspondiente a la variable signo;
            else
            {
                num2 = Double.Parse(txtres.Text);

                switch (signo)
                {
                    case "+":
                        txtres.Text = Convert.ToString(aritmetica.sumar(num1, num2));
                        clic = true;
                        break;

                    case "-":
                        txtres.Text = Convert.ToString(aritmetica.restar(num1, num2));
                        clic = true;
                        break;

                    case "*":
                        txtres.Text = Convert.ToString(aritmetica.multiplicar(num1, num2));
                        clic = true;
                        break;
                    case "/":
                        txtres.Text = Convert.ToString(aritmetica.dividir(num1, num2));
                        clic = true;
                        break;

                }
            }

           
        }

       
    }
}
