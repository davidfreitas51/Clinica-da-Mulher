using ClinicaDaMulher.Models;
using Maroquio;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ClinicaDaMulher.Data
{
    public static class DbWorker
    {
        public static void CriarCliente(List<string> clienteInfo)
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            Cliente cliente = new Cliente()
            {
                Nome = clienteInfo[0],
                CPF = clienteInfo[1],
                Telefone = clienteInfo[2],
            };
            Contexto.Clientes.Add(cliente);
            Contexto.SaveChanges();
        }
        public static bool VerificarCpfValido(string cpf)
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var clientesComCPFIgual = from Clientes in Contexto.Clientes
                                      where Clientes.CPF == cpf
                                      select Clientes;
            if(clientesComCPFIgual.Any())
            {
                return false;
            }
            return true;
        }
        public static SortableBindingList<Consulta> ListarTabelaConsultas()
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            List<Consulta> consultas = Contexto.Consultas.ToList();

            SortableBindingList<Consulta> listaConsultas = new SortableBindingList<Consulta>(consultas);

            return listaConsultas;
        }
        public static SortableBindingList<Cliente> ListarTabelaClientes(string Nome = "", string Cpf = "")
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var clientesRequisitados = from cliente in Contexto.Clientes
                                       where cliente.Nome.ToUpper().Contains(Nome.ToUpper()) &&
                                             cliente.CPF.Contains(Cpf)
                                       select cliente;
            List<Cliente> clientes = clientesRequisitados.ToList();

            SortableBindingList<Cliente> listaClientes = new SortableBindingList<Cliente>(clientes);
            return listaClientes;
        }

        public static SortableBindingList<Razao> ListarTabelaRazoes()
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            List<Razao> razoes = Contexto.Razoes.ToList();

            SortableBindingList<Razao> listaRazoes = new SortableBindingList<Razao>(razoes);

            return listaRazoes;
        }
    }
}
