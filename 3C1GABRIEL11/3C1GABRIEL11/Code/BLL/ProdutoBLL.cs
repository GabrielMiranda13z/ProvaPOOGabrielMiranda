using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1GABRIEL11.Code.DTO;
using _3C1GABRIEL11.Code.DAL;
using System.Data;

namespace _3C1GABRIEL11.Code.BLL
{
    internal class ProdutoBLL
    {

        AcessoBancoDados bd = new AcessoBancoDados();
        string tabela = "produto";



        public void Inserir(ProdutoDTO lojasDTO)
        {

            string inserir = $"insert into {tabela} values('{ lojasDTO.Id}','{ lojasDTO.Produto}','{ lojasDTO.Preco}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(ProdutoDTO lojasDTO)
        {
            string excluir = $"delete from {tabela} where id = '{lojasDTO.Id}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(ProdutoDTO lojasDTO)
        {
            string alterar = $"update {tabela} set produto = '{lojasDTO.Produto}', preco = '{lojasDTO.Preco}' where id = '{lojasDTO.Id}';";
            bd.ExecutarComando(alterar);
        }
    }
}
