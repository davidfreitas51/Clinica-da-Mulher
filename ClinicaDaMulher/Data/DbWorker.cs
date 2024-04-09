using ClinicaDaMulher.Models;
using Maroquio;
using System.Globalization;
using System.Text;

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


        public static SortableBindingList<Consulta> ListarTabelaConsultas(IClinicaDaMulherContext contexto, string nome = "", string cpf = "", string data = "", string motivo = "")
        {
            string cleanStringNome = RemoveDiacritics(nome).ToUpper();
            string cleanStringMotivo = RemoveDiacritics(motivo).ToUpper();
            string cpfSemPontosETraços = cpf.Replace(".", "").Replace("-", "");

            var consultasRequisitadas = (from consultaAnalisada in contexto.Consultas
                                        where consultaAnalisada.CPF.Replace(".", "").Replace("-", "").Contains(cpfSemPontosETraços) &&
                                              (string.IsNullOrEmpty(data) || consultaAnalisada.Data.Replace("/", "")
                                              .Replace(" ", "").Contains(data.Replace("/", "").Replace(" ", "")))
                                       select consultaAnalisada).ToList();

            consultasRequisitadas = consultasRequisitadas.Where(consulta => RemoveDiacritics(consulta.Cliente)
            .ToUpper().Contains(cleanStringNome)).ToList();
            consultasRequisitadas = consultasRequisitadas.Where(consulta => RemoveDiacritics(consulta.Motivo)
            .ToUpper().Contains(cleanStringMotivo)).ToList();

            SortableBindingList<Consulta> listaConsultas = new SortableBindingList<Consulta>(consultasRequisitadas);

            return listaConsultas;
        }
        public static SortableBindingList<Cliente> ListarTabelaClientes(IClinicaDaMulherContext contexto, string Nome = "", string Cpf = "")
        {
            string cleanStringNome = RemoveDiacritics(Nome).ToUpper();
            string cpfSemPontosETraços = Cpf.Replace(".", "").Replace("-", "");

            var clientesRequisitados = (from cliente in contexto.Clientes
                                        where cliente.CPF.Replace(".", "").Replace("-", "").Contains(cpfSemPontosETraços)
                                        select cliente).ToList();
            clientesRequisitados = clientesRequisitados.Where(motivo => RemoveDiacritics(motivo.Nome)
            .ToUpper().Contains(cleanStringNome)).ToList();

            SortableBindingList<Cliente> listaClientes = new SortableBindingList<Cliente>(clientesRequisitados);
            return listaClientes;
        }
        public static SortableBindingList<Motivo> ListarTabelaMotivos(IClinicaDaMulherContext contexto, string nomeDoMotivo = "")
        {
            string cleanString = RemoveDiacritics(nomeDoMotivo).ToUpper();
            var razoesRequisitadas = (from motivo in contexto.Motivos
                                      select motivo).ToList();
            razoesRequisitadas = razoesRequisitadas.Where(motivo => RemoveDiacritics(motivo.Nome)
            .ToUpper().Contains(cleanString)).ToList();

            SortableBindingList < Motivo > listaRazoes = new SortableBindingList<Motivo>(razoesRequisitadas);

            return listaRazoes;
        }
        public static List<string> ListarMotivos(IClinicaDaMulherContext context)
        {
            var motivosRequisitados = from motivo in context.Motivos
                                      orderby motivo.Nome
                                      select motivo.Nome;
            List<string> motivos = motivosRequisitados.ToList();
            return motivos;
        }


        public static void DeletarConsulta(IClinicaDaMulherContext context, string id)
        {

        }
        public static void DeletarCliente(IClinicaDaMulherContext context, int id)
        {
            var clienteADeletar = context.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            if (clienteADeletar != null)
            {
                context.Clientes.Remove(clienteADeletar);
                context.SaveChanges();
            }
        }
        public static void DeletarMotivo(IClinicaDaMulherContext context, int id)
        {
            var motivoADeletar = context.Motivos.FirstOrDefault(motivo => motivo.Id == id);
            if (motivoADeletar != null)
            {
                context.Motivos.Remove(motivoADeletar);
                context.SaveChanges();
            }
        }
        

        public static bool VerificarCpfValido(IClinicaDaMulherContext contexto, string cpf)
        {
            var clientesComCPFIgual = from Clientes in contexto.Clientes
                                      where Clientes.CPF == cpf
                                      select Clientes;
            return !clientesComCPFIgual.Any();
        }
        public static bool ValidarNomeDoMotivo(IClinicaDaMulherContext contexto, string motivo)
        {
            var motivosIguais = from Motivos in contexto.Motivos
                                      where Motivos.Nome.ToLower() == motivo.ToLower()
                                      select Motivos;
            return !motivosIguais.Any();
        }
        public static bool VerificarExistenciaDeMotivo(IClinicaDaMulherContext contexto, string motivo)
        {
            var motivosExistentes = from Motivos in contexto.Motivos
                                    where Motivos.Nome == motivo
                                    select Motivos;
            return motivosExistentes.Any();
        }
        public static string NomePeloCPF(IClinicaDaMulherContext contexto, string cpf)
        {
            var clienteEspecificada = from Clientes in contexto.Clientes
                                      where Clientes.CPF == cpf
                                      select Clientes;
            List<Cliente> clientes = clienteEspecificada.ToList();
            return clientes[0].Nome;
        }
        public static bool ProcurarMotivosDeConsultas(IClinicaDaMulherContext context, string motivo)
        {
            var motivosComConsultas = from consultas in context.Consultas
                                     where consultas.Motivo == motivo
                                     select consultas;
            return motivosComConsultas.Any();
        }
        public static bool ProcurarConsultasPendentes(IClinicaDaMulherContext context, string cpf)
        {
            var clientesComConsulta = from consultas in context.Consultas
                                      where consultas.CPF == cpf
                                      select consultas;
            return clientesComConsulta.Any();
        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder
                .ToString()
                .Normalize(NormalizationForm.FormC);
        }
    }
}
