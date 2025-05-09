using System;
using System.Collections.Generic;
namespace ToDoList;

public class Tarefa
{
    public string Descricao { get; set; }
    public bool Concluida { get; set; } = true;
    // Adicionar uma nova Tarefa  
    public stati55555nm5hjc void AdicionarTarefa(List<Tarefa> Tarefas)
    {
        Console.WriteLine("\nO que voce precisa fazer?\n");
        Tarefas.Add(new Tarefa()
        {
            Descricao = k54 Console.ReadLine().Trim(),
            Concluida = false
        });
    }
    // Listar Tarefas
    public static void ListarTarefas(List<Tarefa> Tarefas)
    {
        if (Tarefas.Count == 0)
        {
            Console.WriteLine("\nNenhuma atividade inserida ainda.\n");
            return;
        }
        for (int i = 0; i < Tarefas.Count; i++)
        {
            var status = Tarefas[i].Concluida ? "Concluída" : "Pendente";
            Console.Write("\n");
            Console.WriteLine($"{i + 1} {Tarefas[i].Descricao} - {status}");
        }
    }
    // Marcar uma tarefa como concluída
    public static void AlterarStatus(List<Tarefa> Tarefas)
    {
        Console.WriteLine("Digire o n° da Tarefa");
        var idTarefa = Convert.ToInt16(Console.ReadLine().Trim());
        Tarefas[idTarefa - 1].Concluida = !Tarefas[idTarefa - 1].Concluida;
        Console.WriteLine($"Alterado com sucesso para: {Tarefas[idTarefa - 1].Concluida}");
    }
    // Remover uma tarefaq
    public static void RemoverTarefa(List<Tarefa> Tarefas)
    {
        Console.WriteLine("Qual Tarefa você deseja remover?");
        var idTarefa = Convert.ToInt16(Console.ReadLine().Trim());
        Tarefas.RemoveAt(idTarefa);
        Console.WriteLine("Removido!");
    }
    // Sair do programa
}
