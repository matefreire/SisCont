using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Br.Ufmt.Web.Curso
{
    public class Usuarios
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("senha")]
        public string Senha { get; set; }
    }

    public class Contas
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("banco")]
        public string Banco { get; set; }

        [Column("contaNumero")]
        public string ContaNumero { get; set; }

        [Column("agencia")]
        public string Agencia { get; set; }
    }

    public class Despesas
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("fundo")]
        public string Fundo { get; set; }

        [Column("valor")]
        public float Valor { get; set; }
    }

    public class Receitas
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("recurso")]
        public string Recurso { get; set; }

        [Column("orgao")]
        public string Orgao { get; set; }

        [Column("valor")]
        public float Valor { get; set; }
    }

    public class Empenhos
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("despesa")]
        public string Despesa { get; set; }

        [Column("valor")]
        public string Valor { get; set; }

    }

    public class Liquidacoes
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("empenho")]
        public string Empenho { get; set; }

        [Column("valor")]
        public float Valor { get; set; }

    }

    public class Pagamentos
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("liquidacao")]
        public string Liquidacao { get; set; }

        [Column("valor")]
        public float Valor { get; set; }

    }

    public class Estoque
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("produto")]
        public string Produto { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("valorCusto")]
        public float ValorCusto { get; set; }

    }

    public class Vendas
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("cliente")]
        public string Cliente { get; set; }

        [Column("produto")]
        public string Produto { get; set; }

        [Column("quantidade")]
        public float Quantidade { get; set; }

    }
    public class Clientes
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("email")]
        public string Email { get; set; }

    }

}