namespace CadastrodeVendaPoo.Classes{
    public class Produto{
        private int id;
        private string nomeproduto;
        private string descricao;

        private double preco;

        public Produto (){ 
            /// <summary>
            /// Constroi o objeto produto e voce precisa passar os dados como parametro
            /// </summary>
            /// <param name="id"> Passar a identificação do produto partnumber como numeral</param>
            /// <param name="nomeproduto">Passe o nome do produto como texto </param>
            /// <param name="descricao">Passe a descrição do produto com texto</param>
            /// <param name="preco">Passe o valor do produto em moeda</param>
            /// <returns></returns>           
            
        }
        public Produto(int id, string nomeproduto,string descricao, double preco){

            this.id = id;
            this.nomeproduto = nomeproduto;
            this.descricao = descricao;
            this.preco = preco;
            
        }
        public int Id { get{return id;} set{id = value;}}
        public string NomeProduto { get{return nomeproduto;} set{nomeproduto = value;}}
        public string  Descricao { get{return descricao;} set{descricao = value;} } 
        public double Preco  { get{return preco;} set{preco = value;} }     
        
    }
}
    


