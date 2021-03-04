using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMCFatec2021
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txt_altura.Text) || string.IsNullOrEmpty(txt_peso.Text))
                {
                    throw new Exception("Informe os dados corretamente.");
                }

                double altura = Convert.ToDouble(txt_altura.Text);
                double peso = Convert.ToDouble(txt_peso.Text);

                double imc = peso / (altura * altura);


                string classificacao = "";

                if(imc < 17)
                {
                    classificacao = "Muito abaixo do peso";

                } else if(imc >= 17 && imc < 18.49)
                {
                    classificacao = "Abaixo do Peso";

                } else if(imc >= 18.49 && imc < 24.99)
                {
                    classificacao = "Peso normal";

                } else if(imc >= 24.99 && imc < 29.99)
                {
                    classificacao = "Acima do peso";

                } else if (imc >= 29.99 && imc < 34.99)
                {
                    classificacao = "Obesidade Grau I";

                } else if (imc >= 34.99 && imc < 39.99)
                {
                    classificacao = "Obesidade Grau II";

                } else if(imc >= 40)
                {
                    classificacao = "Obesidade Grau III";
                }


                /**
                 * Apresentando os reusltados para o Usuário.
                 */
                lbl_resultado.Text = "Seu IMC é " + imc.ToString("0.00") + " está " + classificacao;


            } catch (Exception ex)
            {
                lbl_resultado.Text = ex.Message;
            }
        }
    }
}
