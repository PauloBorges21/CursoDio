using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            int idade;
            string cep;
            string fixo;
            string celular;
            fixo = "(11)2919-1798";
            string empresa;
            double valor;
            empresa = "0800-200-4336";

            celular = "(11)96804-2887";
            cep = "31555-440";
            valor = 26.333333;
            //idade = 32;
            //Console.WriteLine("Sua idade é: " + idade);


            string retorno = TratarCEP(cep);
            string retornoCel = TratarFone(celular);
            string retornofixo = TratarFone(fixo);
            string retornoempresa = TratarFone(empresa);
            string retornomoeda = TratarMoeda(valor);
            Console.WriteLine(retorno);
            Console.WriteLine(retornofixo);
            Console.WriteLine(retornoCel);
            Console.WriteLine(retornoempresa);
            Console.WriteLine(retornomoeda);
            Console.WriteLine("Executando finalizada. Tecle enter para sair...");

            Console.ReadLine();



        }

        public static string TratarCEP(string Cep)
        {
            try
            {
                Cep = Cep.Replace("-", "");

                return Convert.ToUInt64(Cep).ToString(@"00000\-000");

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static string TratarFone(string Fone)
        {
            try
            {
                Fone = Fone.Replace("(", "").Replace(")", "").Replace("-", "");
                if (Fone.Length == 10)
                {
                    return Convert.ToUInt64(Fone).ToString(@"(\00\)0000\-0000");
                }
                else if (Fone.Length > 10 && Fone.Substring(0, 4).ToString() == "0800")
                {
                    return Convert.ToUInt64(Fone).ToString(@"\0000\-000\-0000");
                }
                else
                {
                    return Convert.ToUInt64(Fone).ToString(@"(\00\)00000\-0000");
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static string TratarMoeda(double valor)
        {
            NumberFormatInfo mNumberFormatInfo = new CultureInfo("en-US", false).NumberFormat;
            int[] mTamGrupo1 = { 2, 4, 3 };
            //valor = valor.Replace(".", "");
            mNumberFormatInfo.CurrencyGroupSizes = mTamGrupo1;


            return valor.ToString("C", mNumberFormatInfo).Replace("$","");
        }
    }


}
