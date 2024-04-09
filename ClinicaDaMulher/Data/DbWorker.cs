using ClinicaDaMulher.Models;
using Maroquio;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ClinicaDaMulher.Data
{
    public static class DbWorker
    {
        public static void CriarConsulta(IClinicaDaMulherContext contexto, Consulta consulta)
        {
            contexto.Consultas.Add(consulta);
            contexto.SaveChanges();
        }
        public static void CriarCliente(IClinicaDaMulherContext contexto, Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }
        public static void CriarMotivo(IClinicaDaMulherContext contexto, Motivo novoMotivo)
        {
            contexto.Motivos.Add(novoMotivo);
            contexto.SaveChanges();
        }

        public static bool VerificarCpfValido(IClinicaDaMulherContext contexto, string cpf)
        {
            var clientesComCPFIgual = from Clientes in contexto.Clientes
                                      where Clientes.CPF == cpf
                                      select Clientes;
            if(clientesComCPFIgual.Any())
            {
                return false;
            }
            return true;
        }
        public static SortableBindingList<Consulta> ListarTabelaConsultas(IClinicaDaMulherContext contexto, string nome = "", string cpf = "", string data = "", string motivo = "")
        {
            string cpfSemPontosETraços = cpf.Replace(".", "").Replace("-", "");
            var consultasRequisitadas = from consultaAnalisada in contexto.Consultas
                                        where consultaAnalisada.Cliente.ToUpper().Contains(nome.ToUpper()) &&
                                              consultaAnalisada.CPF.Replace(".", "").Replace("-", "").Contains(cpfSemPontosETraços) &&
                                              consultaAnalisada.Motivo.ToUpper().Contains(motivo.ToUpper()) &&
                                              (string.IsNullOrEmpty(data) || consultaAnalisada.Data.Replace("/", "")
                                              .Replace(" ", "").Contains(data.Replace("/", "").Replace(" ", "")))
                                       select consultaAnalisada;

            List<Consulta> consultas = consultasRequisitadas.ToList();
            SortableBindingList<Consulta> listaConsultas = new SortableBindingList<Consulta>(consultas);

            return listaConsultas;
        }
        public static SortableBindingList<Cliente> ListarTabelaClientes(IClinicaDaMulherContext contexto, string Nome = "", string Cpf = "")
        {
            string cpfSemPontosETraços = Cpf.Replace(".", "").Replace("-", "");

            // Filtra os clientes com base no nome e CPF
            var clientesRequisitados = contexto.Clientes
                .Where(cliente => cliente.Nome.ToUpper().Contains(Nome.ToUpper()) &&
                                   cliente.CPF.Replace(".", "").Replace("-", "").Contains(cpfSemPontosETraços));

            // Converte o resultado em uma lista
            List<Cliente> clientes = clientesRequisitados.ToList();

            // Cria uma lista classificável de clientes
            SortableBindingList<Cliente> listaClientes = new SortableBindingList<Cliente>(clientes);
            return listaClientes;
        }

        public static SortableBindingList<Motivo> ListarTabelaMotivos(IClinicaDaMulherContext contexto, string nomeDoMotivo = "")
        {
            var razoesRequisitadas = from motivo in contexto.Motivos
                                     where motivo.Nome.ToUpper().Contains(nomeDoMotivo.ToUpper())
                                     select motivo;

            List < Motivo > razoes = razoesRequisitadas.ToList();

            SortableBindingList<Motivo> listaRazoes = new SortableBindingList<Motivo>(razoes);

            return listaRazoes;
        }
        public static List<string> ListarMotivos(IClinicaDaMulherContext context)
        {
            var motivosRequisitados = from motivo in context.Motivos
                                      select motivo.Nome;
            List<string> motivos = motivosRequisitados.ToList();
            return motivos;
        }
        public static bool ValidarNomeDoMotivo(IClinicaDaMulherContext contexto, string motivo)
        {
            var motivosIguais = from Motivos in contexto.Motivos
                                      where Motivos.Nome.ToLower() == motivo.ToLower()
                                      select Motivos;
            if (motivosIguais.Any())
            {
                return false;
            }
            return true;
        }
        public static bool VerificarExistenciaDeMotivo(IClinicaDaMulherContext contexto, string motivo)
        {
            var motivosExistentes = from Motivos in contexto.Motivos
                                    where Motivos.Nome == motivo
                                    select Motivos;
            if (motivosExistentes.Any())
            {
                return true;
            }
            return false;
        }
        public static string NomePeloCPF(IClinicaDaMulherContext contexto, string cpf)
        {
            var clienteEspecificada = from Clientes in contexto.Clientes
                                      where Clientes.CPF == cpf
                                      select Clientes;
            List<Cliente> clientes = clienteEspecificada.ToList();
            return clientes[0].Nome;
        }
    }
}
