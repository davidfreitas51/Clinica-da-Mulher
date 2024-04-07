using ClinicaDaMulher.Migrations;
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
            string cpfSemPontosETraços = Cpf.Replace(".", "").Replace("-", "");

            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var clientesRequisitados = from cliente in Contexto.Clientes
                                       where cliente.Nome.ToUpper().Contains(Nome.ToUpper()) &&
                                             cliente.CPF.Replace(".", "").Replace("-", "").Contains(cpfSemPontosETraços)
                                       select cliente;

            List<Cliente> clientes = clientesRequisitados.ToList();

            SortableBindingList<Cliente> listaClientes = new SortableBindingList<Cliente>(clientes);
            return listaClientes;
        }

        public static SortableBindingList<Motivo> ListarTabelaMotivos(string nomeDoMotivo = "")
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var razoesRequisitadas = from motivo in Contexto.Motivos
                                     where motivo.Nome.ToUpper().Contains(nomeDoMotivo.ToUpper())
                                     select motivo;

            List < Motivo > razoes = razoesRequisitadas.ToList();

            SortableBindingList<Motivo> listaRazoes = new SortableBindingList<Motivo>(razoes);

            return listaRazoes;
        }
        public static List<string> ListarMotivos()
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var motivosRequisitados = from motivo in Contexto.Motivos
                                      select motivo.Nome;
            List<string> motivos = motivosRequisitados.ToList();
            return motivos;
        }
        public static bool ValidarNomeDoMotivo(string motivo)
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            var motivosIguais = from Motivos in Contexto.Motivos
                                      where Motivos.Nome.ToLower() == motivo.ToLower()
                                      select Motivos;
            if (motivosIguais.Any())
            {
                return false;
            }
            return true;
        }
        public static void CriarMotivo(Motivo novoMotivo)
        {
            ClinicaDaMulherContext Contexto = new ClinicaDaMulherContext();
            Contexto.Motivos.Add(novoMotivo);
            Contexto.SaveChanges();
        }
    }
}
