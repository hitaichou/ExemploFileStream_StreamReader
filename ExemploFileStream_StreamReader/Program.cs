using System;
using System.IO;

namespace ExemploFileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            
            StreamReader sr = null;

            try
            {
                //usando o while para ler todos as linhas
                //! --> Enquanto NÃO chegar no final da streamreader, continua imprimindo
                while(!sr.EndOfStream) //Usa o EndOfStream para somente sair quando acabar todas as linhas
                {
                    //é possível chamar a classe File
                    //e ele já instancia o filestream e o streamreader juntos
                    sr = File.OpenText(path);
                    string line = sr.ReadLine(); //armazeno o que foi lido
                    Console.WriteLine(line); //imprimo em tela
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An erro occured.");
                Console.WriteLine(e.Message);
            }
            //bloco para fechar o arquivo de forma manual
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
               
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
