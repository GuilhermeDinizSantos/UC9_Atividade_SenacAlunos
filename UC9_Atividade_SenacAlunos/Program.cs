string[,] dados = new string[5, 4];
int uc = 0;
int c = 0;
string controle = "a";
int escolha = 0;
string pesquisar = "";
double total = 0;
double conta1 = 0;
double conta2 = 0;

while (controle != "b")
{
    escolha = 0;
    Console.Clear();
    Console.WriteLine("|======================================================================|");
    Console.WriteLine("|=================  -> 1: cadastrar informações <-  ===================|");
    Console.WriteLine("|=================  -> 2: pesquisar informações <-  ===================|");
    Console.WriteLine("|==========================  -> 3: sair <-  ===========================|");
    Console.WriteLine("|======================================================================|");
    escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            for (uc = 0; uc < 5; uc++)
            {
                Console.Clear();
                c = 0;
                Console.WriteLine("=>Informe o Número da UC:");
                dados[uc, c++] = Console.ReadLine();
                Console.WriteLine("=>Informe a descrição da UC:");
                dados[uc, c++] = Console.ReadLine();
                Console.WriteLine("=>Informe a carga horária da UC:");
                dados[uc, c++] = Console.ReadLine();
                Console.WriteLine("=>Informe a duração da aula:");
                dados[uc, c++] = Console.ReadLine();
            }
            break;
        case 2:
            Console.Clear();
            for (uc = 0;uc < 5; uc++)
            {
                Console.WriteLine("Qual UC procura?");
                pesquisar = Console.ReadLine();
                if (pesquisar == dados [uc, 0])
                {
                    conta1 = double.Parse(dados[uc, 2]) * 0.25;
                    conta2 = double.Parse(dados[uc,3]);
                    total = conta1 / conta2;
                    Console.WriteLine("A UC "+dados[uc, 0]+" tem como descrição: " +dados[uc,1]+ "\nSua carga horária é de: "+dados[uc,2]+" e você pode faltar " + total.ToString("F") + " dias, ou: " + conta1 + " horas de aula");
                }
            }
            break;
        case 3:
            controle = "b";
            break;
            default:
            Console.WriteLine("Opção não encontrada. Retornando ao menu");
            Console.ReadLine();
            break;
    }
}