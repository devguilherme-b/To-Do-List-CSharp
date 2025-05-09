using System;
using System.Collections.Generic;
using ToDoList;
using CSharpShellCore;

namespace ToDoList;

public static class Program
{
    public static void Main()
    {
        List<Tarefa> Tarefas = new List<Tarefa>();
        Console.WriteLine("Olá! Sou sua lista de tarefas :)");
        bool iniciarPrograma = true;
        while (iniciarPrograma is true)
        {
            Console.WriteLine("\nEscolha uma opção:\n1 - Adicionar Tarefa;\n2 - Listar Tarefas;\n3 - Modificar Status de uma Tarefa;\n4 - Remover Tarefa;\n5 - Sair do Programa.");
            var escolha = Convert.ToInt16(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Tarefa.AdicionarTarefa(Tarefas);
                    break;
                case 2:
                    Tarefa.ListarTarefas(Tarefas);
                    break;
                case 3:
                    Tarefa.AlterarStatus(Tarefas);
                    break;
                case 4:
                    Tarefa.RemoverTarefa(Tarefas);
                    break;
                case 5:
                    // Pensando no que fazer aqui
                    Console.WriteLine("Até mais");
                    fecharPrograma();
                    break;
                default:
                    Console.WriteLine("Algo deu errado!");
                    break;
            }
        }
        void fecharPrograma()
        {
            iniciarPrograma = false;
        }
    }
}
