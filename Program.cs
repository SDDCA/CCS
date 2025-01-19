using System;

namespace OCC
{

    class Program
    {

        static void Main(string[] args)
        {
            
            float val_pg;
            Console.Write("Informar nome do cliente: "); 
            string var_nome = Console.ReadLine();

            Console.Write("Informar Endereço: "); 
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)?");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {

                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;

                Console.Write("Informar CPF: "); 
                pf.cpf = Console.ReadLine();

                Console.Write("Informar RG: "); 
                pf.rg = Console.ReadLine();

                Console.Write("Informar valor da compra: "); 
                if (float.TryParse(Console.ReadLine(), out val_pg))

                {
                    pf.Pagar_Imposto(val_pg);

                    Console.WriteLine("\nPessoa Física");
                    Console.WriteLine($"{"Nome:",-20}{pf.nome,20}");
                    Console.WriteLine($"{"Endereço:",-20}{pf.endereco,20}");
                    Console.WriteLine($"{"CPF:",-20}{pf.cpf,20}");
                    Console.WriteLine($"{"RG:",-20}{pf.rg,20}");
                    Console.WriteLine($"{"Valor da compra:",-20}{pf.valor.ToString("C"),20}");
                    Console.WriteLine($"{"Imposto:",-20}{pf.valor_imposto.ToString("C"),20}");
                    Console.WriteLine($"{"Total:",-20}{pf.total.ToString("C"),20}");

                }
                else
                {

                    Console.WriteLine("Erro: valor da compra inválido!");

                }

            }
            else if (var_tipo == "j")
            {

                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;

                Console.Write("Informar CNPJ: "); 
                pj.cnpj = Console.ReadLine();

                Console.Write("Informar IE: "); 
                pj.ie = Console.ReadLine();

                Console.Write("Informar valor da compra: "); 
                if (float.TryParse(Console.ReadLine(), out val_pg))

                {
                    pj.Pagar_Imposto(val_pg);

                    Console.WriteLine("\nPessoa Jurídica");
                    Console.WriteLine($"{"Nome:",-20}{pj.nome,20}");
                    Console.WriteLine($"{"Endereço:",-20}{pj.endereco,20}");
                    Console.WriteLine($"{"CNPJ:",-20}{pj.cnpj,20}");
                    Console.WriteLine($"{"IE:",-20}{pj.ie,20}");
                    Console.WriteLine($"{"Valor da compra:",-20}{pj.valor.ToString("C"),20}");
                    Console.WriteLine($"{"Imposto:",-20}{pj.valor_imposto.ToString("C"),20}");
                    Console.WriteLine($"{"Total:",-20}{pj.total.ToString("C"),20}");

                }
                else
                {

                    Console.WriteLine("Erro: valor da compra inválido!");

                }
            }
            else
            {

                Console.WriteLine("Erro: tipo de cliente inválido!");

            }
        }
    }
}
