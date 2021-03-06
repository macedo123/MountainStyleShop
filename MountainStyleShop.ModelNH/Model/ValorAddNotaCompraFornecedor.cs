﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;

namespace MountainStyleShop.ModelNH.Model
{
    public class ValorAddNotaCompraFornecedor
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataDeBase { get; set; }
        public virtual double Valor { get; set; }
        public virtual NotaDeCompraFornecedor NotaCompraFornecedor { get; set; }
        public virtual TipoValorAdd TipoValor { get; set; }
    }

    public class ValorAddNotaCompraFornecedorMap : ClassMapping<ValorAddNotaCompraFornecedor>
    {
        public ValorAddNotaCompraFornecedorMap()
        {
            Id<int>(x => x.Id, m =>
            {
                m.Generator(Generators.Identity);
            });

            Property<DateTime>(x => x.DataDeBase);
            Property<double>(x => x.Valor);

            ManyToOne<NotaDeCompraFornecedor>(x => x.NotaCompraFornecedor, m =>
            {
                m.Column("NotaCompraFornecedor");
            });

            ManyToOne<TipoValorAdd>(x => x.TipoValor, m =>
            {
                m.Column("TipoValor");
            });

        }
    }
}