using System;

namespace CadastroVendaPoo.Classes{
    public class Venda{
        private string cpf;
        private int id;
        public DateTime datavenda;
        public Venda(){
            /// <summary>
            /// Constroi o objeto venda e voce precisa passar os dados como parametro
            /// </summary>
            /// <param name="cpf">Passe o cpf do cliente</param>
            /// <param name="id">Passe a id do produto da venda</param>
            /// <param name="datavenda">Passe a data da venda do produto</param>
            /// <returns></returns>
            
        }
        public Venda(string cpf, int id, DateTime datavenda){
            this.cpf = cpf;
            this.id = id;
            this.datavenda = datavenda;           
            
        }
        public string Cpf { get{return cpf;} set{cpf = value;}}
        public int Id { get{return id;} set{id = value;}}
        public DateTime DataVenda  { get{return datavenda;} set{datavenda = value;} } 
    }

}