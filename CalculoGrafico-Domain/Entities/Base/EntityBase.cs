using prmToolkit.NotificationPattern;
using System;


namespace CalculoGrafico_Domain.Entities.Base
{
   public abstract class EntityBase :Notifiable
    {
        protected EntityBase()
        {

            Id = new Guid();
            DataCadastro = DateTime.Now;

        }

        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
