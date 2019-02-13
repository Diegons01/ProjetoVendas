using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<RegistroVenda> registroVendas { get; set; } = new List<RegistroVenda>();        

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
        }

        public void AddVendas(RegistroVenda venda)
        {
            registroVendas.Add(venda);
        }

        public void RemoverVendas(RegistroVenda venda)
        {
            registroVendas.Remove(venda);
        }
        public double TotalVendas(DateTime inicio, DateTime Final)
        {
            return 0.0;
        }
    }
}
