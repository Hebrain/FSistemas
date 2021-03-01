using System.Collections.Generic;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {
        /// <summary>
        /// Inclui um novo Beneficiario
        /// </summary>
        /// <param name="beneficiario">Objeto de Beneficiario</param>
        public long Incluir(DML.Beneficiario beneficiario)
        {
            DAL.DaoBeneficiario DBeneficiario = new DAL.DaoBeneficiario();
            return DBeneficiario.Incluir(beneficiario);
        }

        /// <summary>
        /// Altera um Beneficiario
        /// </summary>
        /// <param name="beneficiario">Objeto de Beneficiario</param>
        public void Alterar(DML.Beneficiario beneficiario)
        {
            DAL.DaoBeneficiario DBeneficiario = new DAL.DaoBeneficiario();
            DBeneficiario.Alterar(beneficiario);
        }

        /// <summary>
        /// Consulta o beneficiario pelo id
        /// </summary>
        /// <param name="id">id do beneficiario</param>
        /// <returns></returns>
        public DML.Beneficiario Consultar(long id)
        {
            DAL.DaoBeneficiario DBeneficiario = new DAL.DaoBeneficiario();
            return DBeneficiario.Consultar(id);
        }

        /// <summary>
        /// Excluir o beneficiario pelo id
        /// </summary>
        /// <param name="id">id do Cliente</param>
        /// <returns></returns>
        public void Excluir(long IdCliente)
        {
            DAL.DaoBeneficiario DBeneficiario = new DAL.DaoBeneficiario();
            DBeneficiario.Excluir(IdCliente);
        }

        /// <summary>
        /// Lista os beneficiarios
        /// </summary>
        public List<DML.Beneficiario> Listar(long IdCliente)
        {
            DAL.DaoBeneficiario DBeneficiario = new DAL.DaoBeneficiario();
            return DBeneficiario.Listar(IdCliente);
        }

        

        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF, long Id, long IdCliente)
        {
            DAL.DaoBeneficiario DBeneficiario = new DAL.DaoBeneficiario();
            return DBeneficiario.VerificarExistencia(CPF, Id, IdCliente);
        }
    }
}
