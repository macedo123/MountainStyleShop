﻿using MountainStyleShop.ModelNH.Config;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System.Linq;

namespace MountainStyleShop.ModelNH.Model
{
    public class ItemVendaCliente
    {
        public virtual int Id { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual double ValorUnitario { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual VendaCliente VendaCliente { get; set; }

        public virtual double ValorTotal()
        {
            if (this.VendaCliente.VendaConfirmada)
            {
                return this.Quantidade * this.ValorUnitario;
            }
            else
            {
                return this.Quantidade * this.Produto.Valor;
            }
            
        }

        
    }

    public class ItemVendaClienteMap : ClassMapping<ItemVendaCliente>
    {
        public ItemVendaClienteMap()
        {
            Id<int>(x => x.Id, m =>
            {
                m.Generator(Generators.Identity);
            });

            Property<int>(x => x.Quantidade);
            Property<double>(x => x.ValorUnitario);

            ManyToOne<Produto>(x => x.Produto, m =>
            {
                m.Column("Produto");
            });

            ManyToOne<VendaCliente>(x => x.VendaCliente, m =>
            {
                m.Column("VendaCliente");
            });
        }
    }
}