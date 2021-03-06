﻿using System.Collections.Generic;

namespace DesafioFULL.Dominio.Entidades
{
    public class Titulo: EntidadeBase
    {
        public long ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int QtdeParcelas { get; set; }
        public decimal PerJuros { get; set; }
        public decimal PerMulta { get; set; }
        public decimal VlrOriginal { get; set; }
        public decimal VlrJuros { get; set; }
        public decimal VlrMulta { get; set; }
        public decimal VlrCorrigido { get; set; }
        public int DiasEmAtraso { get; set; }

        public virtual ICollection<TituloParcela> Parcelas { get; set; }

        public override void Validar()
        {
            LimparMensagensValidacao();

            if (ClienteId == 0)
                AdicionarMensagemValidacao("Cliente devedor não pode estar vazio");

        }
    }
}
