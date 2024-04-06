using ClinicaDaMulher.Models;
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
        public static List<Consulta> ListarTabelaConsultas()
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            return Contexto.Consultas.ToList();
        }
        public static List<Cliente> ListarTabelaClientes(string Nome = "", string Cpf = "")
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var clientesRequisitados = from cliente in Contexto.Clientes
                                       where cliente.Nome.Contains(Nome) &&
                                             cliente.CPF.Contains(Cpf)
                                       select cliente;
            return clientesRequisitados.ToList();
        }

        public static List<Razao> ListarTabelaRazoes()
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            return Contexto.Razoes.ToList();
        }
    }
}
